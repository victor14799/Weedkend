drop database Weedkend
create database Weedkend
use Weedkend

create table Brand(
				BrandID varchar(10) primary key,
				BrandName nvarchar(50) not null
					)
					
create table Category(
				CategoryID varchar(10) primary key,
				CategoryName nvarchar(100) not null
						)
create table Product(
				ProductID uniqueidentifier default newID() primary key,
				ProName nvarchar(100) not null,
				ProBrand varchar(10) foreign key references Brand(BrandID) not null,
				Category varchar(10) foreign key references Category(CategoryID) not null,
				Price float not null,
				ImgURL nvarchar(MAX) not null,
				Description nvarchar(MAX),
				Status nchar(10) not null
					)

create table Role(
				RoleID int primary key,
				RoleName nvarchar(20) not null
					)

create table Account(
				UserName varchar(25) primary key,
				Password varchar(50) not null,
				FullName nvarchar(50) not null,
				Role int foreign key references Role(RoleID) not null,
				PhoneNo varchar(10) not null,
				Email varchar(100) not null,
				Address nvarchar(MAX) not null,
				Status varchar(10) not null
					)

create table Customer(
				CustomerID uniqueidentifier default newID() primary key,
				FullName nvarchar(100) not null,
				ShipAddress nvarchar(500) not null,
				PhoneNo char(10) not null
)
create table Orders(	
				OrderID uniqueidentifier default newID() primary key,
				CustomerID uniqueidentifier foreign key references Customer(CustomerID) null,
				UserName varchar(25) foreign key references Account(UserName) null,
				Datetime date not null, 
					)

create table OrdersDetail(
						OrderID uniqueidentifier foreign key references Orders(OrderID),
						ProductID uniqueidentifier foreign key references Product(ProductID) not null,
						UnitPrice float not null,
						Quantity int not null,
						primary key(OrderID,ProductID)
						)