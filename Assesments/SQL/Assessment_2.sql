-- 1.	Write a query to display your birthday( day of week)

Create database Assessment_2
use Assessment_2

Create Table Friends (
	Name varchar(20),
	BirthDate Date
	);

Insert Into Friends(Name, BirthDate) Values 
	('Basavaraj', '2000-07-21'),
	('Shantesh', '2001-02-14'),
	('Shashikanth', '2000-01-10');

SELECT DATENAME(dw, BirthDate) AS Day_Of_Week
FROM Friends
WHERE BirthDate = '2000-07-21';

--OUTPUT:
-- Friday

-------------------------------------------------------------------------------------

-- 2. Write a query to display your age in days


SELECT DATEDIFF(day, '2000-07-21', GETDATE()) AS AgeInDays;


-- Explaination: 'DATEDIFF' This function calculates the difference between two dates like Given date & Current date

-- OUTPUT:
-- AgeInDays
-- 8651

-------------------------------------------------------------------------------------------

-- 3. Write a query to display all employees information those who joined before 5 years in the current month
 
use Assignment_2; 

SELECT empo, ename, hiredate
FROM EMP
WHERE DATEDIFF(year, hiredate, GETDATE()) >= 5
AND MONTH(hiredate) = MONTH(GETDATE());



-------------------------------------------------------------------------------------------


-- 4. Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction

BEGIN TRANSACTION;

CREATE TABLE Employee (
    empno INT PRIMARY KEY,
    ename VARCHAR(50),
    sal DECIMAL(10, 2),
    doj DATE
);


-- a. Insert 3 rows into the Employee table

INSERT INTO Employee (empno, ename, sal, doj)
VALUES (1, 'Basavaraj', 50000, '2022-01-01'),
       (2, 'Shashikant', 60000, '2023-03-15'),
       (3, 'Shantesh', 55000, '2024-02-10');

--select * from Employee

--DROP TABLE Employee;


-- b. Update the salary of the second row with a 15% increment

UPDATE Employee
SET sal = sal * 1.15
WHERE empno = 2;


-- c. Delete the first row

DELETE FROM Employee
WHERE empno = 1;

COMMIT;

-- Start a new transaction
BEGIN TRANSACTION;

-- Create a temporary table to store the deleted row
CREATE TABLE DeletedEmployee (
    empno INT,
    ename VARCHAR(50),
    sal DECIMAL(10, 2),
    doj DATE
);

-- Insert the deleted row into the temporary table
INSERT INTO DeletedEmployee
SELECT empno, ename, sal, doj
FROM Employee
WHERE empno = 1;

ROLLBACK;

SELECT * FROM Employee;

SELECT * FROM DeletedEmployee;

DROP TABLE DeletedEmployee;


-------------------------------------------------------------------------------------

-- 5. Create a user defined function calculate Bonus for all employees of a  given job using 	following conditions


Create table Employee(empno numeric(10) primary key,
	ename varchar(20),
	DeptNo INT, 
	sal DECIMAL(10, 2)
	);

Insert into Employee (empno, ename, DeptNo, sal) values 
	(1, 'Basavaraj', 10, 20000), 
	(2, 'Basavaraj', 12, 25000), 
	(3, 'Basavaraj', 13, 12000), 
	(4, 'Basavaraj', 14, 23000), 
	(5, 'Basavaraj', 20, 18000);

select * From Employee

Drop table Employee

CREATE FUNCTION CalculateBonus (@DeptNo INT, @sal DECIMAL(10, 2))
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @bonus DECIMAL(10, 2);

--	a. For Deptno 10 employees 15% of sal as bonus.
    IF @deptno = 10
        SET @bonus = 0.15 * @sal;

--	b. For Deptno 20 employees  20% of sal as bonus

    ELSE IF @deptno = 20
        SET @bonus = 0.20 * @sal;

--	c. For Others employees 5%of sal as bonus

    ELSE
        SET @bonus = 0.05 * @sal;

    RETURN @bonus;
END;


SELECT empno, ename, sal, dbo.CalculateBonus(DeptNo, sal) AS bonus
FROM Employee;

-- OUTPUT

--1	Basavaraj	20000.00	3000.00
--2	Basavaraj	25000.00	1250.00
--3	Basavaraj	12000.00	600.00
--4	Basavaraj	23000.00	1150.00
--5	Basavaraj	18000.00	3600.00