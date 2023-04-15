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

