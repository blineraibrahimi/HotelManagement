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