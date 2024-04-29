CREATE DATABASE Employeemanagement;

USE Employeemanagement;

CREATE TABLE Employee_Details (
    Empno INT PRIMARY KEY,
    EmpName VARCHAR(50) NOT NULL,
    Empsal NUMERIC(10,2) CHECK (Empsal >= 25000),
    Emptype CHAR(1) CHECK (Emptype IN ('P', 'C'))
);

-------------------------------------------------------------------------

CREATE PROCEDURE AddEmployee
    @EmpName VARCHAR(50),
    @Empsal NUMERIC(10,2),
    @Emptype CHAR(1)
AS
BEGIN
    DECLARE @Empno INT;
    SELECT @Empno = ISNULL(MAX(Empno), 0) + 1 FROM Employee_Details;

    INSERT INTO Employee_Details (Empno, EmpName, Empsal, Emptype)
    VALUES (@Empno, @EmpName, @Empsal, @Emptype);
END;

-------------------------------------------------------------------------

Select * From Employee_Details;


--Drop Table Employee_Details;

