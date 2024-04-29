CREATE DATABASE Assessment_1;
USE Assessment_1;

CREATE TABLE book (
    id numeric(4) PRIMARY KEY,
    title varchar(100),
    author varchar(100),
    isbn numeric(20),
    published_date date
);

INSERT INTO book (id, title, author, isbn, published_date) VALUES
	(1, 'My First SQL book', 'Mary Parker', 981483029127, '2012-02-22'),
	(2, 'My Second SQL book', 'John Mayer', 857300923713, '1972-07-03'),
	(3, 'My Third SQL book', 'CAry Flint', 523120967812, '2015-10-18');

SELECT * FROM book;

------------------------------------------------------------------------------------------------------
CREATE TABLE reviews (
    id numeric(4) PRIMARY KEY,
    book_id numeric(4) REFERENCES book(id),
    reviewer_name varchar(100),
    content varchar(100),
    rating numeric(10),
    published_date date
);

INSERT INTO reviews (id, book_id, reviewer_name, content, rating, published_date) VALUES 
	(1, 1, 'John Smith', 'My first review', 4, '2017-12-10'),
	(2, 2, 'John Smith', 'My second review', 5, '2017-10-13'),
	(3, 2, 'Alice walker', 'Another review', 1, '2017-10-22');

SELECT * FROM reviews;

------------------------------------------------------------------------------------------------------

-- 1) Write a query to fetch the details of the books written by author whose name ends with er.

SELECT *
FROM book
WHERE author LIKE '%er';

-- 2) Display the Title ,Author and ReviewerName for all the books from the above table

SELECT b.title, b.author, r.reviewer_name
FROM book b
JOIN reviews r ON b.id = r.book_id;

-- 3) Display the reviewer name who reviewed more than one book.

SELECT reviewer_name
FROM reviews
GROUP BY reviewer_name
HAVING COUNT(DISTINCT book_id) > 1;

---------------------------------------------------------------------------------------


CREATE TABLE Customertable (
	ID numeric(15),
	NAME varchar(15),
	AGE numeric(5),
	ADDRESS varchar(20),
	SALARY numeric(20)
);

INSERT INTO Customertable (ID, NAME, AGE, ADDRESS, SALARY) VALUES
	(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
	(2, 'Khilan', 25, 'Delhi', 1500.00),
	(3, 'Kaushik', 23, 'Kota', 2000.00),
	(4, 'Chaitali', 25, 'Mumbai', 6500.00),
	(5, 'Hardik', 27, 'Bhopal', 8500.00),
	(6, 'Komal', 22, 'MP', 4500.00),
	(7, 'Muffy', 24, 'Indoor', 10000.00);

SELECT * FROM Customertable;

-- 4) Display the Name for the customer from above customer table who live in same address which has character o anywhere in address

SELECT NAME
FROM Customertable
WHERE ADDRESS LIKE '%o%';


---------------------------------------------------------------------------------------

CREATE TABLE Ordertable (
	OID numeric(15) PRIMARY KEY,
	DATE DATE,
	CUSTOMER_ID numeric(15),
	AMOUNT numeric(15)
);

INSERT INTO Ordertable (OID, DATE, CUSTOMER_ID, AMOUNT) VALUES
	(102, '2009-10-08', 3, 3000),
	(100, '2009-10-08', 3, 1500),
	(101, '2009-11-20', 2, 1560),
	(103, '2008-05-20', 4, 2060);

SELECT * FROM Ordertable;

-- 5) Write a query to display the Date,Total no of customer placed order on same Date

--SELECT DATE, COUNT(DISTINCT CUSTOMER_ID) AS Total_Customers_Placed_Order
--FROM Ordertable
--GROUP BY DATE;

SELECT DATE, COUNT( CUSTOMER_ID) AS Total_Customers_Placed_Order  --Don't use Distinct
FROM Ordertable
GROUP BY DATE;

-- 6) Display the Names of the Employee in lower case, whose salary is null

SELECT LOWER(NAME) AS Lowercase_Name
FROM Customertable
WHERE SALARY IS NULL;


---------------------------------------------------------------------------------------

