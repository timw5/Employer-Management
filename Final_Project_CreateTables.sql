Create Schema Tim_Williams_Final

GO

Create Table Tim_Williams_Final.Departments
(
    DeptID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    DeptName nvarchar(255) default SYSDATETIME(),
    [Location] nvarchar(255) default(' '),
    ContactName nvarchar(50) default(' '),
    ContactPhone nvarchar(50) default(' ')
)

GO

Create Table Tim_Williams_Final.Employees
(
    EmployeeID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    FirstName nvarchar(50),
    LastName nvarchar(50),
    AddressL1 nvarchar(255) default(' '),
    AddressL2 nvarchar(255) default(' '),
    City nvarchar(255) default(' '),
    [State] nvarchar(255) default(' '),
    [Zip] int default(-1),
    SSN nvarchar(20) default(' '),
    Department nvarchar(255) default(' '),
    EmployeeType nvarchar(255) default(' '),
    DateJoined datetime2 default SYSDATETIME(),
    BirthDate datetime2 default SYSDATETIME(),
    Marrried bit default 0,
    Salary decimal(10,2) default 0,
    CommissionRate Decimal(10, 2) default 0,
    Sales decimal(10,2) default 0
)


