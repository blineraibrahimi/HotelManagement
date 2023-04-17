CREATE DATABASE HotelManagement;

CREATE TABLE [Customers] (
  [CustomerID] int NOT NULL IDENTITY(1,1),
  [CustomerName] nvarchar(20) ,
  [CustomerLastname] nvarchar(20),
  [Address] nvarchar(255),
  [ContatcNo] nvarchar(30),
  [CustomerIDNo] nvarchar(25),
  [Description] nvarchar(255),
  PRIMARY KEY ([CustomerID])
);

CREATE TABLE [Employees] (
  [EmployeeID] int NOT NULL IDENTITY(1,1),
  [EmployeeName] nvarchar(20) ,
  [EmployeeLastname] nvarchar(20) ,
  [Email] nvarchar(30),
  [ContactNo] nvarchar(30),
  [LoginID] nvarchar(30),
  [Password] nvarchar(50),
  [EmployeeType] nvarchar(20),
  [Description] nvarchar(255),
  PRIMARY KEY ([EmployeeID])
);

CREATE TABLE [Rooms] (
  [RoomID] int NOT NULL IDENTITY(1,1),
  [RoomName] nvarchar(30),
  [RoomNumber] int,
  [Capacity] int,
  [Rate] decimal,
  [Status] nvarchar(10),
  [Description] nvarchar(255),
  PRIMARY KEY ([RoomID])
);

CREATE TABLE [HouseKeeping] (
  [HousekeepindID] int NOT NULL IDENTITY(1,1),
  [EmployeeID] int NOT NULL,
  [RoomID] int NOT NULL,
  [HousekeepingDate] datetime,
  [HousekeppingStatus] nvarchar(10),
  [Description] nvarchar(255),
  PRIMARY KEY ([HousekeepindID]),
  FOREIGN KEY (EmployeeID) REFERENCES EMPLOYEE(EmployeeID),
  FOREIGN KEY (RoomID) REFERENCES ROOMS(RoomID)
);

CREATE TABLE [Bookings] (
  [BookingID] int NOT NULL IDENTITY(1,1),
  [RoomID] int,
  [EmployeeID] int,
  [BookingDate] date,
  [CheckIn] datetime,
  [CheckOut] datetime,
  [RangeOfDays] int,
  [TotalCost] decimal,
  [Status] nvarchar(10),
  [Description] nvarchar(255),
  PRIMARY KEY ([BookingID]),
  FOREIGN KEY (RoomID) REFERENCES ROOMS(RoomID),
  FOREIGN KEY (EmployeeID) REFERENCES EMPLOYEE(EmployeeID)
);

CREATE TABLE [Payments] (
  [PaymentID] int NOT NULL IDENTITY(1,1),
  [BookingID] int,
  [Amount] decimal,
  [PaymentType] nvarchar(20),
  [PaymentDetails] nvarchar(255),
  [PaymentDate] datetime,
  [Status] nvarchar(10),
  [Description] nvarchar(255),
  PRIMARY KEY ([PaymentID]),
  FOREIGN KEY (BookingID) REFERENCES BOOKINGS(BookingID)
);

CREATE TABLE [BookingCustomers] (
  [BookingID] int,
  [CustomerID] int,
  [Description] nvarchar(255),
  PRIMARY KEY ([BookingID], [CustomerID]),
  FOREIGN KEY (CustomerID) REFERENCES CUSTOMERS(CustomerID),
  FOREIGN KEY (BookingID) REFERENCES BOOKINGS(BookingID)
);