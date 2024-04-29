-- 1.	Write a T-SQL Program to find the factorial of a given number.

CREATE FUNCTION dbo.GetFactorial (@number INT)
RETURNS BIGINT
AS
BEGIN
    DECLARE @factorial BIGINT = 1;

    IF @number < 0
        SET @factorial = NULL;
    ELSE
    BEGIN
        WHILE @number > 1
        BEGIN
            SET @factorial = @factorial * @number;
            SET @number = @number - 1;
        END
    END

    RETURN @factorial;
END


SELECT dbo.GetFactorial(8) AS FactorialOf8;


-- 2.	Create a stored procedure to generate multiplication tables up to a given number.

CREATE PROCEDURE dbo.GenerateMultiplicationTables 
    @maxNumber INT
AS
BEGIN
    DECLARE @counter INT = 1;

    WHILE @counter <= @maxNumber
    BEGIN
        DECLARE @multiplier INT = 1;

        PRINT 'Multiplication Table for ' + CAST(@counter AS VARCHAR(10)) + ':';

        WHILE @multiplier <= 10
        BEGIN
            DECLARE @result INT = @counter * @multiplier;
            PRINT CAST(@counter AS VARCHAR(10)) + ' x ' + CAST(@multiplier AS VARCHAR(10)) + ' = ' + CAST(@result AS VARCHAR(10));
            SET @multiplier = @multiplier + 1;
        END

        PRINT ''; 
        SET @counter = @counter + 1;
    END
END


EXEC dbo.GenerateMultiplicationTables @maxNumber = 5;


-- 3.  Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc
-- Note: Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. try to match and stop manipulation 

CREATE TABLE holiday (
    holiday_date DATE PRIMARY KEY,
    holiday_name VARCHAR(100)
);

INSERT INTO holiday (holiday_date, holiday_name) VALUES 
    ('2024-01-26', 'Republic Day'),
    ('2924-08-15', 'Independence Day'),
    ('2024-10-02', 'Birth of Mahatma Gandhi'),
    ('2024-11-14', 'Childrens Day');

SELECT * FROM holiday;

