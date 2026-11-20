use UpgradeMySelf
go

-- table create by Do Tien Luong
CREATE TABLE CarInfo(
	ID int not null primary key,
	CarName nvarchar(50), 
	CarType nvarchar(50),
	CarSpeed decimal,
	CarPrice decimal(18,2)
);
GO
-- Thay đổi thứ tự attribute bằng cách kéo lại thứ tự
-- Lưu ý: Nếu SSMS báo lỗi "Saving changes is not permitted", 
-- bạn vào menu Tools -> Options -> Designers -> bỏ tích mục Prevent saving changes that require table re-creation, 
-- rồi bấm OK và lưu lại.

create table brand (
	ID int not null primary key,
	BrandName nvarchar(50)
);
Go


-- Update attribute of table.
ALTER TABLE CarInfo
ALTER Column CarType nvarchar (50)
GO
-- Update single, can not group.
ALTER TABLE CarInfo
ALTER Column CarSpeed float
GO

CREATE TABLE CarInfo(
	ID int not null primary key,
	CarName nvarchar(50), 
	CarType nvarchar(50),
	CarSpeed decimal,
	CarPrice decimal(18,2)
);
GO

create table brand (
	ID int not null primary key,
	BrandName nvarchar(50)
);
Go

Insert into CarInfo (ID, CarName, CarType, CarSpeed, CarPrice)
VALUES
    (1, N'Toyota Camry', N'Sedan', 1235000000.00, 210.5),
    (2, N'VinFast VF 8', N'SUV', 1090000000.00, 200.0),
    (3, N'Ford Ranger', N'Bán tải', 965000000.00, 180.0);
Go
