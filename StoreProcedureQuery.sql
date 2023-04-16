GO
CREATE PROCEDURE GetEmployees
AS
BEGIN
	SELECT EmployeeID, EmployeeName, EmployeeLastName, Email, ContactNo, LoginID, [Password], EmployeeType, [Description] FROM  HotelManagementDB.dbo.Employees
END
GO
--==========================================
GO
CREATE PROCEDURE CreateEmployee
	@EmployeeName nvarchar(20),
	@EmployeeLastName nvarchar(20),
	@Email nvarchar(30),
	@ContactNo nvarchar(30),
	@LoginID nvarchar(30),
	@Password nvarchar(50),
	@EmployeeType nvarchar(20),
	@Description nvarchar(255)
AS
BEGIN
	INSERT INTO HotelManagementDB.dbo.Employees(EmployeeName, EmployeeLastName, Email, ContactNo, LoginID, [Password], EmployeeType, [Description])
    VALUES (@EmployeeName, @EmployeeLastName, @Email, @ContactNo, @LoginID, @Password, @EmployeeType, @Description);
END
GO
--==========================================
CREATE PROCEDURE UpdateEmployee
    @Id INT,
	@EmployeeName nvarchar(20),
	@EmployeeLastName nvarchar(20),
	@Email nvarchar(30),
	@ContactNo nvarchar(30),
	@LoginID nvarchar(30),
	@Password nvarchar(50),
	@EmployeeType nvarchar(20),
	@Description nvarchar(255)
AS
BEGIN
    UPDATE Employees SET EmployeeName = @EmployeeName, EmployeeLastname = @EmployeeLastName, Email = @Email, ContactNo = @ContactNo, 
		LoginID = @LoginID, [Password] = @Password, EmployeeType = @EmployeeType, [Description] = @Description
    WHERE EmployeeID = @Id;
END
--==========================================
GO
CREATE PROCEDURE DeleteEmployee
    @Id INT
AS
BEGIN
    DELETE FROM Employees WHERE EmployeeID = @Id;
END
--==========================================
GO
CREATE PROCEDURE GetCustomers
AS
BEGIN
	SELECT CustomerID, CustomerName, CustomerLastname, [Address], ContactNo, CustomerIDNo, [Description] FROM  HotelManagementDB.dbo.Customers
END
GO
--==========================================
GO
CREATE PROCEDURE CreateCustomer
	@CustomerName nvarchar(20),
	@CustomerLastname nvarchar(20),
	@Address nvarchar(255),
	@ContactNo nvarchar(30),
	@CustomerIDNo nvarchar(25),
	@Description nvarchar(255)
AS
BEGIN
	INSERT INTO HotelManagementDB.dbo.Customers(CustomerName, CustomerLastname, [Address], ContactNo, CustomerIDNo, [Description])
    VALUES (@CustomerName, @CustomerLastname, @Address, @ContactNo, @CustomerIDNo, @Description);
END
GO
--==========================================
GO
CREATE PROCEDURE UpdateCustomer
    @Id INT,
	@CustomerName nvarchar(20),
	@CustomerLastname nvarchar(20),
	@Address nvarchar(255),
	@ContactNo nvarchar(30),
	@CustomerIDNo nvarchar(25),
	@Description nvarchar(255)
AS
BEGIN
    UPDATE Customers SET CustomerName = @CustomerName, CustomerLastname = @CustomerLastname, [Address] = @Address, ContactNo = @ContactNo, 
		CustomerIDNo = @CustomerIDNo, [Description] = @Description
    WHERE CustomerID = @Id;
END
GO
--==========================================
GO
CREATE PROCEDURE DeleteCustomer
    @Id INT
AS
BEGIN
    DELETE FROM Customers WHERE CustomerID = @Id;
END
GO
--==========================================
