
Create Database transystem;


Create table Client(
	Id int IDENTITY(1,1) PRIMARY KEY,
	DocumentNumber varchar(50),
	Name varchar(50),
	IsTypeClient bit,
	IsDeleted bit,
	CreateDate Date,
	UpdatedDate Date,
	DeletedDate Date,
	CreatedByPersonId int,
	UpdatedPersonId int,
	DeletedByPersonId int,
);
GO

Create table AddressX(

	Id int IDENTITY(1,1) PRIMARY KEY,
	ClientId int NOT NULL,
	Street varchar(50),
	Complement varchar(50),
	ZipCode varchar(15),
	Number int,
	IsDeleted bit,
	CreateDate Date,
	UpdatedDate Date,
	DeletedDate Date,
	CreatedByPersonId int,
	UpdatedPersonId int,
	DeletedByPersonId int,

);
GO

Create table OrderX(

	Id int IDENTITY(1,1) PRIMARY KEY,
	ClientId int NOT NULL,
	DriverId int not null,
	Name varchar(50),
	Type varchar(50),
	StartDate Date,
	EndDate Date,
	StartAddress varchar(100),
	EndAddress varchar(100),
	CreateDate Date,
	UpdatedDate Date,
	DeletedDate Date,
	CreatedByPersonId int,
	UpdatedPersonId int,
	DeletedByPersonId int,

);
GO

Create table Driver(

	Id int IDENTITY(1,1) PRIMARY KEY,
	DocumentNumber varchar(50),
	Name varchar(50),
	BirthDate Date,
	DriverLicense varchar(50),
	IsDeleted bit,
	CreateDate Date,
	UpdatedDate Date,
	DeletedDate Date,
	CreatedByPersonId int,
	UpdatedPersonId int,
	DeletedByPersonId int,

);
GO

Create table Truck(

	Id int IDENTITY(1,1) PRIMARY KEY,
	DriverId int not null,
	Place varchar(18),
	Model varchar(50),

	IsDeleted bit,
	CreateDate Date,
	UpdatedDate Date,
	DeletedDate Date,
	CreatedByPersonId int,
	UpdatedPersonId int,
	DeletedByPersonId int,

);
GO

Create table Trailer(

	Id int IDENTITY(1,1) PRIMARY KEY,
	TruckId int not null,
	Name varchar(50),
);
GO


Create table UserX(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Name varchar(50),
	Login varchar(50),
	Password varchar(50),

	IsActive bit,
	CreateDate Date,
	UpdatedDate Date,
	DeletedDate Date,
	CreatedByPersonId int,
	UpdatedPersonId int,
	DeletedByPersonId int,
);
GO