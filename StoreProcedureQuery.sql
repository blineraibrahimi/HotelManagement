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
GO
CREATE PROCEDURE GetRooms
AS
BEGIN
	SELECT RoomID, RoomName, RoomNumber, Capacity, Rate, [Status], [Description] FROM  HotelManagementDB.dbo.Rooms
END
GO
--==========================================
GO
CREATE PROCEDURE CreateRoom
	@RoomName nvarchar(30),
	@RoomNumber int,
	@Capacity int,
	@Rate decimal,
	@Status nvarchar(10),
	@Description nvarchar(255)
AS
BEGIN
	INSERT INTO HotelManagementDB.dbo.Rooms(RoomName, RoomNumber, Capacity, Rate, [Status], [Description])
    VALUES (@RoomName, @RoomNumber, @Capacity, @Rate, @Status, @Description);
END
GO
--==========================================
GO
CREATE PROCEDURE UpdateRoom
    @Id INT,
	@RoomName nvarchar(30),
	@RoomNumber int,
	@Capacity int,
	@Rate decimal,
	@Status nvarchar(10),
	@Description nvarchar(255)
AS
BEGIN
    UPDATE Rooms SET RoomName = @RoomName, RoomNumber = @RoomNumber, Capacity = @Capacity, Rate = @Rate, 
		[Status] = @Status, [Description] = @Description
    WHERE RoomID = @Id;
END
GO
--==========================================
GO
CREATE PROCEDURE DeleteRoom
    @Id INT
AS
BEGIN
    DELETE FROM Rooms WHERE RoomID = @Id;
END
GO
--==========================================
GO
CREATE PROCEDURE GetHouseKeeping
AS
BEGIN
	SELECT HousekeepingID, EmployeeID, RoomID, HousekeepingDate, HousekeppingStatus, [Description] FROM  HotelManagementDB.dbo.HouseKeeping
END
GO
--==========================================
GO
CREATE PROCEDURE CreateHouseKeeping
	@EmployeeID int,
	@RoomID int,
	@HousekeepingDate datetime,
	@HousekeppingStatus nvarchar(10),
	@Description nvarchar(255)
AS
BEGIN
	INSERT INTO HotelManagementDB.dbo.HouseKeeping(EmployeeID, RoomID, HousekeepingDate, HousekeppingStatus, [Description])
    VALUES (@EmployeeID, @RoomID, @HousekeepingDate, @HousekeppingStatus, @Description);
END
GO
--==========================================
GO
CREATE PROCEDURE UpdateHouseKeeping
    @Id INT,
	@EmployeeID int,
	@RoomID int,
	@HousekeepingDate datetime,
	@HousekeppingStatus nvarchar(10),
	@Description nvarchar(255)
AS
BEGIN
    UPDATE HouseKeeping SET EmployeeID = @EmployeeID, RoomID = @RoomID, HousekeepingDate = @HousekeepingDate, HousekeppingStatus = @HousekeppingStatus, [Description] = @Description
    WHERE HousekeepingID = @Id;
END
GO
--==========================================
GO
CREATE PROCEDURE DeleteHouseKeeping
    @Id INT
AS
BEGIN
    DELETE FROM HouseKeeping WHERE HousekeepingID = @Id;
END
GO
--==========================================
GO
CREATE PROCEDURE GetBookings
AS
BEGIN
	SELECT BookingID, EmployeeID, RoomID, BookingDate, CheckIn, CheckOut, RangeOfDays, TotalCost, [Status], [Description] FROM  HotelManagementDB.dbo.Bookings
END
GO
--==========================================
GO
CREATE PROCEDURE CreateBooking
	@EmployeeID int,
	@RoomID int,
	@BookingDate date,
	@CheckIn datetime,
	@CheckOut datetime,
	@RangeOfDays int,
	@TotalCost decimal,
	@Status nvarchar(10),
	@Description nvarchar(255)
AS
BEGIN
	INSERT INTO HotelManagementDB.dbo.Bookings(EmployeeID, RoomID, BookingDate, CheckIn, CheckOut, RangeOfDays, TotalCost, [Status], [Description])
    VALUES (@EmployeeID, @RoomID, @BookingDate, @CheckIn, @CheckOut, @RangeOfDays, @TotalCost, @Status, @Description);
END
GO
--==========================================
GO
CREATE PROCEDURE UpdateBooking
    @Id INT,
	@EmployeeID int,
	@RoomID int,
	@BookingDate date,
	@CheckIn datetime,
	@CheckOut datetime,
	@RangeOfDays int,
	@TotalCost decimal,
	@Status nvarchar(10),
	@Description nvarchar(255)
AS
BEGIN
    UPDATE Bookings SET EmployeeID = @EmployeeID, RoomID = @RoomID, BookingDate = @BookingDate, CheckIn = @CheckIn, CheckOut = @CheckOut, RangeOfDays = @RangeOfDays, 
	TotalCost = @TotalCost, [Status] = @Status, [Description] = @Description
    WHERE BookingID = @Id;
END
GO
--==========================================
GO
CREATE PROCEDURE DeleteBooking
    @Id INT
AS
BEGIN
    DELETE FROM Bookings WHERE BookingID = @Id;
END
GO
--==========================================
