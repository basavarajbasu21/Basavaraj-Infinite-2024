Create database EKART

Use EKART

-- Create Customer Table
CREATE TABLE Customers (
    CustomerId INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    PhoneNumber NVARCHAR(20),
    Address NVARCHAR(255)
);

-- Create Item Table
CREATE TABLE Items (
    ItemId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Price DECIMAL(10, 2),
    Description NVARCHAR(MAX)
);

-- Create Order Table
CREATE TABLE Orders (
    OrderId INT PRIMARY KEY IDENTITY(1,1),
    CustomerId INT FOREIGN KEY REFERENCES Customers(CustomerId),
    OrderDate DATETIME,
    TotalAmount DECIMAL(10, 2),
    CONSTRAINT FK_CustomerOrder FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
);

-- Create OrderItem Table (Many-to-Many Relationship between Orders and Items)
CREATE TABLE OrderItems (
    OrderItemId INT PRIMARY KEY IDENTITY(1,1),
    OrderId INT,
    ItemId INT,
    Quantity INT,
    CONSTRAINT FK_OrderItem_Order FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),
    CONSTRAINT FK_OrderItem_Item FOREIGN KEY (ItemId) REFERENCES Items(ItemId)
);

-- Sample Data for Customers
INSERT INTO Customers (FirstName, LastName, Email, PhoneNumber, Address)
VALUES ('John', 'Doe', 'john@example.com', '1234567890', '123 Main St'),
       ('Jane', 'Smith', 'jane@example.com', '9876543210', '456 Elm St');

-- Sample Data for Items
INSERT INTO Items (Name, Price, Description)
VALUES ('Smartphone', 500.00, 'Latest smartphone model'),
       ('Laptop', 1000.00, 'High-performance laptop'),
       ('Headphones', 50.00, 'Wireless headphones');

-- Sample Data for Orders
INSERT INTO Orders (CustomerId, OrderDate, TotalAmount)
VALUES (1, GETDATE(), 550.00),
       (2, GETDATE(), 1050.00);

-- Sample Data for OrderItems (Mapping Orders with Items)
INSERT INTO OrderItems (OrderId, ItemId, Quantity)
VALUES (1, 1, 1), -- John bought 1 Smartphone
       (1, 3, 2), -- John bought 2 Headphones
       (2, 2, 1), -- Jane bought 1 Laptop
       (2, 3, 1); -- Jane bought 1 Headphones


Select * from Customers
Select * from Items
Select * from Orders
Select * from OrderItems