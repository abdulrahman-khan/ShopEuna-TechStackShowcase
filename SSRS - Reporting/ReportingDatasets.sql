-- CompletedOrders View
ALTER VIEW CompletedOrders AS
Select 
	dbo.Payments.OrderID, PaymentDate as 'Payment_Date', dbo.Customers.FirstName as 'First_Name', dbo.Customers.LastName as 'Last Name', Amount, PaymentMethod as 'Payment_Method', OrderDate as 'Order_Date', 
	dbo.Products.Name as 'Product_Name'
FROM dbo.Payments
	inner join dbo.Orders ON dbo.Orders.OrderID = dbo.Payments.OrderID
	inner join dbo.Products ON dbo.Products.ProductID = dbo.Payments.OrderID
	inner join dbo.Customers ON dbo.Customers.CustomerID = dbo.Orders.CustomerID
WHERE 1=1 
	and dbo.Payments.Status = 'Completed'
;


--select * from CompletedOrders;

--Select 
--	PaymentID, dbo.Payments.OrderID, PaymentDate as 'Payment_Date', Amount, PaymentMethod as 'Payment_Method', OrderDate as 'Order_Date', 
--	dbo.Products.Name as 'Product_Name'
--FROM dbo.Payments
--	inner join dbo.Orders ON dbo.Orders.OrderID = dbo.Payments.OrderID
--	inner join dbo.Products ON dbo.Products.ProductID = dbo.Payments.OrderID
--WHERE 1=1 
--	and dbo.Payments.Status = 'Completed'
--;




--Select 
--	*
--FROM dbo.Payments
--	inner join dbo.Orders ON dbo.Orders.OrderID = dbo.Payments.OrderID
--	inner join dbo.Products ON dbo.Products.ProductID = dbo.Payments.OrderID
--	inner join dbo.Customers ON dbo.Customers.CustomerID = dbo.Orders.CustomerID
--WHERE 1=1 
--	and dbo.Payments.Status = 'Completed'
--;

