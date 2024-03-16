create database SQL1

use SQL1

-------------------------------------------------------------------------------------------

create table tclients
(
	Client_ID numeric(4) primary key,
	Cname varchar(40) not null,
	Address varchar(30),
	Email varchar(30) unique,
	Phone numeric(10),
	Business varchar(20) not null,
)



insert into tClients(Client_ID,Cname,Address,Email,Phone,Business) values(1001,'ACME Utilities','Noida','contact@acmeutil.com',9567880032,'Manufacturing');

insert into tClients(Client_ID,Cname,Address,Email,Phone,Business) values(1002,'Trackon Consultants','Mumbai','consult@trackon.com',8734210090,'Consultant'),(1003,'MoneySaver Distributors','Kolkata','save@moneysaver.com',7799886655,'Reseller'),
(1004,'Lawful Corp','Chennai','justice@lawful.com',9210342219,'Professional');

select * from tClients;

-------------------------------------------------------------------------------------------------
create table tEmployees
(
Empno Numeric(4) primary key,
Ename varchar(20) not null,
Job varchar(15),
Salary Numeric(7) check(Salary>0),
Deptno Numeric(2) references tDepartments(Deptno)
)

insert into tEmployees (Empno,Ename,Job,Salary,Deptno) values (7001,'Sandeep','Analyst',25000,10),(7002,'Rajesh','Designer',30000,10),(7003,'Madhav','Developer',40000,20),
(7004,'Manoj','Developer',40000,20),(7005,'Abhay','Designer',35000,10),(7006,'Uma','Tester',30000,30),(7007,'Gita','Tech.Writer',30000,40),
(7008,'Priya','Tester',35000,30),(7009,'Nutan','Developer',45000,20),(7010,'Smita','Analyst',20000,10),(7011,'Anand','Project Mgr',65000,10);

Alter table tEmployees
Add  Foreign key (Deptno) references tbDepartments(Deptno)

select * from tEmployees;

-------------------------------------------------------------------------------------

create table tDepartments
(
Deptno Numeric(2) primary key,
Dname varchar(15) not null,
Loc varchar(20)
)


insert into tDepartments(Deptno,Dname,Loc) values(10,'Design','Pune'),(20,'Development','Pune'),(30,'Testing','Mumbai'),(40,'Document','Mumbai');

select * from tDepartments;

------------------------------------------------------------------------------------------

create table tProjects
(
Project_ID Numeric(3) primary key,
Descr varchar(30) not null,
StartDate Date,
Planned_End_Date Date,
Actual_End_Date Date,
Budget Numeric(10) check(Budget>0),
Client_ID Numeric(4) references tClients(Client_ID),
constraint datecheck check(Actual_End_Date>=Planned_End_Date),
)

insert into tProjects (Project_ID,Descr,StartDate,Planned_End_Date,Actual_End_Date,Budget,Client_ID) values (401,'Inventory','01-Apr-11','01-Oct-11','31-Oct-11',150000,1001);
insert into tProjects (Project_ID,Descr,StartDate,Planned_End_Date,Budget,Client_ID) values (402,'Accounting','01-Aug-11','01-Jan-12',500000,1002),(403,'Payroll','01-Oct-11','31-Dec-11',75000,1003),
(404,'Contact Mgmt','01-Nov-11','31-Dec-11',50000,1004);

select * from tProjects;

-----------------------------------------------------------------------------------------

CREATE TABLE tEmpProjectTasks (
    Project_ID NUMERIC(3) REFERENCES tProjects(Project_ID),
    Empno NUMERIC(4) REFERENCES tEmployees(Empno),
    StartDate DATE,
    End_Date DATE,
    Task VARCHAR(25),
    Status VARCHAR(15)
);

INSERT INTO tEmpProjectTasks VALUES
    (401, 7001, '2011-04-01', '2011-04-20', 'System Analysis', 'Completed'),
    (401, 7002, '2011-04-21', '2011-05-30', 'System Design', 'Completed'),
    (401, 7003, '2011-06-01', '2011-07-15', 'Coding', 'Completed'),
    (401, 7004, '2011-07-18', '2011-09-01', 'Coding', 'Completed'),
    (401, 7006, '2011-09-03', '2011-09-15', 'Testing', 'Completed'),
    (401, 7009, '2011-09-18', '2011-10-05', 'Code Change', 'Completed'),
    (401, 7008, '2011-10-06', '2011-10-16', 'Testing', 'Completed'),
    (401, 7007, '2011-10-06', '2011-10-22', 'Documentation', 'Completed'),
    (401, 7011, '2011-10-22', '2011-10-31', 'Sign off', 'Completed'),
    (402, 7010, '2011-08-01', '2011-08-20', 'System Analysis', 'Completed'),
    (402, 7002, '2011-08-22', '2011-09-30', 'System Design', 'Completed');

INSERT INTO tEmpProjectTasks (Project_ID, Empno, StartDate, Task, Status) 
VALUES (402, 7004, '2011-10-01', 'Coding', 'In Progress');

SELECT * FROM tEmpProjectTasks;

--------------------------------------------------------------------------------------------
