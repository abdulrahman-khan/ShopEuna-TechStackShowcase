use	NewEuna2025;


-- get all the customer ids
SELECT DISTINCT customerid FROM Customers
ORDER BY customerid;

-- get specific customer id
SELECT customerid, firstname, lastname, email, gender, age, phone, address_city, address_state, address_country
FROM Customers;


-- get all the orders for that specific customer
SELECT 
	oi.OrderItemID, oi.ProductID, oi.Quantity, oi.UnitPrice, ord.CustomerID, ord.OrderDate, ord.TotalAmount, pr.Name as 'Product_Name', de.Name as 'Department_Name'
	--*
FROM OrderItems as oi
	INNER JOIN Orders as ord on ord.OrderID = oi.OrderID
	INNER JOIN Products as pr on pr.ProductID = oi.ProductID
	INNER JOIN Departments as de on de.DepartmentID = pr.DepartmentID
WHERE
	ord.CustomerID = 3
ORDER BY 
	ord.OrderDate


;