-- USE ShopEuna database
USE ShopEuna;

-- Insert into Departments
INSERT INTO Departments (DepartmentID, Name) VALUES
(1, 'Electronics'),
(2, 'Clothing'),
(3, 'Home & Kitchen'),
(4, 'Books'),
(5, 'Toys'),
(6, 'Health & Beauty'),
(7, 'Sports'),
(8, 'Automotive'),
(9, 'Garden'),
(10, 'Office Supplies');

-- Insert into Customers
INSERT INTO Customers (CustomerID, FirstName, LastName, Email, CreatedDate) VALUES
(1, 'Alice', 'Smith', 'alice@example.com', '2023-01-15'),
(2, 'Bob', 'Johnson', 'bob@example.com', '2023-02-20'),
(3, 'Carol', 'Williams', 'carol@example.com', '2023-03-18'),
(4, 'David', 'Brown', 'david@example.com', '2023-04-05'),
(5, 'Eve', 'Jones', 'eve@example.com', '2023-05-12'),
(6, 'Frank', 'Miller', 'frank@example.com', '2023-06-22'),
(7, 'Grace', 'Davis', 'grace@example.com', '2023-07-30'),
(8, 'Henry', 'Garcia', 'henry@example.com', '2023-08-10'),
(9, 'Ivy', 'Martinez', 'ivy@example.com', '2023-09-01'),
(10, 'Jack', 'Rodriguez', 'jack@example.com', '2023-10-11');

-- Insert into Products
INSERT INTO Products (ProductID, Name, Price, DepartmentID) VALUES
(1, 'Smartphone', 599.99, 1),
(2, 'Laptop', 899.99, 1),
(3, 'Jeans', 49.99, 2),
(4, 'Blender', 29.99, 3),
(5, 'Cookbook', 19.99, 4),
(6, 'Action Figure', 15.99, 5),
(7, 'Shampoo', 8.49, 6),
(8, 'Basketball', 24.99, 7),
(9, 'Car Wax', 14.99, 8),
(10, 'Desk Organizer', 12.99, 10);

-- Insert into Orders
INSERT INTO Orders (OrderID, CustomerID, OrderDate, TotalAmount) VALUES
(1, 1, '2023-06-01', 614.98),
(2, 2, '2023-06-03', 64.98),
(3, 3, '2023-06-04', 44.98),
(4, 4, '2023-06-05', 29.99),
(5, 5, '2023-06-06', 35.98),
(6, 6, '2023-06-07', 899.99),
(7, 7, '2023-06-08', 24.99),
(8, 8, '2023-06-09', 14.99),
(9, 9, '2023-06-10', 8.49),
(10, 10, '2023-06-11', 12.99);

-- Insert into OrderItems
INSERT INTO OrderItems (OrderItemID, OrderID, ProductID, Quantity, UnitPrice) VALUES
(1, 1, 1, 1, 599.99),
(2, 1, 6, 1, 15.99),
(3, 2, 3, 1, 49.99),
(4, 2, 10, 1, 14.99),
(5, 3, 5, 2, 19.99),
(6, 4, 4, 1, 29.99),
(7, 5, 6, 1, 15.99),
(8, 5, 7, 1, 19.99),
(9, 6, 2, 1, 899.99),
(10, 7, 8, 1, 24.99);

-- Insert into Payments
INSERT INTO Payments (PaymentID, OrderID, PaymentDate, Amount, PaymentMethod, Status) VALUES
(1, 1, '2023-06-01', 614.98, 'Credit Card', 'Completed'),
(2, 2, '2023-06-03', 64.98, 'PayPal', 'Completed'),
(3, 3, '2023-06-04', 44.98, 'Credit Card', 'Completed'),
(4, 4, '2023-06-05', 29.99, 'Debit Card', 'Completed'),
(5, 5, '2023-06-06', 35.98, 'Credit Card', 'Pending'),
(6, 6, '2023-06-07', 899.99, 'Credit Card', 'Completed'),
(7, 7, '2023-06-08', 24.99, 'PayPal', 'Completed'),
(8, 8, '2023-06-09', 14.99, 'Debit Card', 'Completed'),
(9, 9, '2023-06-10', 8.49, 'Credit Card', 'Failed'),
(10, 10, '2023-06-11', 12.99, 'PayPal', 'Completed');
