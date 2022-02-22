USE [master]
GO
CREATE DATABASE [ServiceManager]
GO
USE [ServiceManager]
GO
CREATE TABLE [dbo].[Customer](
[id][int] IDENTITY(1,1) NOT NULL,
[FirstName] [nvarchar](100) NOT NULL,
[LastName] [nvarchar](100) NOT NULL,
[AddressName] [nvarchar](200) NOT NULL,
[AddressNumber] [int] NOT NULL,
[PhoneNumber] [varchar](20) NOT NULL,
[EmailAddress] [nvarchar](100) NOT NULL,
[ServicePackageId] [int] NOT NULL,
[Registered] [datetime] NOT NULL, 
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[ServicePackage](
[id][int] IDENTITY(1,1) NOT NULL,
[InternetServiceId] [int] NULL,
[InternetServiceDurationMonths] [int] NULL,
[InternetServiceStartingDate] [datetime] NULL,
[InternetServiceEndingDate] [datetime] NULL,
[TvServiceId] [int] NULL,
[TvServiceDurationMonths] [int] NULL,
[TvServiceStartingDate] [datetime] NULL,
[TvServiceEndingDate] [datetime] NULL,
[PhoneServiceId] [int] NULL,
[PhoneServiceDurationMonths] [int] NULL,
[PhoneServiceStartingDate] [datetime] NULL,
[PhoneServiceEndingDate] [datetime] NULL,
 CONSTRAINT [PK_ServicePackage] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[InternetService](
[id][int] IDENTITY(1,1) NOT NULL,
[Name] [nvarchar](100) NOT NULL,
[Speed] [nvarchar](100) NOT NULL,
[CostPerMonth] [money] NOT NULL,
 CONSTRAINT [PK_InternetService] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[TvService](
[id][int] IDENTITY(1,1) NOT NULL,
[Name] [nvarchar](100) NOT NULL,
[ChannelCount] [int] NOT NULL,
[CostPerMonth] [money] NOT NULL,
 CONSTRAINT [PK_TvService] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[PhoneService](
[id][int] IDENTITY(1,1) NOT NULL,
[Name] [nvarchar](100) NOT NULL,
[TalkingMinutes] [int] NOT NULL,
[MessageAmount] [int] NOT NULL,
[CostPerMonth] [money] NOT NULL,
 CONSTRAINT [PK_PhoneService] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ServicePackage]  ADD  CONSTRAINT [FK_InternetService] FOREIGN KEY([InternetServiceId])
REFERENCES [dbo].[InternetService] ([id])
GO

ALTER TABLE [dbo].[ServicePackage]  ADD  CONSTRAINT [FK_TvService] FOREIGN KEY([TvServiceId])
REFERENCES [dbo].[TvService] ([id])
GO

ALTER TABLE [dbo].[ServicePackage]  ADD  CONSTRAINT [FK_PhoneService] FOREIGN KEY([PhoneServiceId])
REFERENCES [dbo].[PhoneService] ([id])
GO

ALTER TABLE [dbo].[Customer]  ADD  CONSTRAINT [FK_ServicePackage] FOREIGN KEY([ServicePackageId])
REFERENCES [dbo].[ServicePackage] ([id])
ON DELETE CASCADE
ON UPDATE CASCADE
GO

CREATE PROCEDURE [dbo].[spCustomer_Insert]
@FirstName nvarchar(100),
@LastName nvarchar (100),
@AddressName nvarchar(200),
@AddressNumber int,
@PhoneNumber varchar (20),
@EmailAddress nvarchar (100),
@ServicePackageId int,
@Registered datetime,
@id int =0 output
AS
BEGIN

	SET NOCOUNT ON;
	insert into dbo.Customer(FirstName,LastName,AddressName,AddressNumber,PhoneNumber,EmailAddress,ServicePackageId,Registered)
	values (@FirstName, @LastName, @AddressName, @AddressNumber,@PhoneNumber,@EmailAddress,@ServicePackageId,@Registered);
	select @id = SCOPE_IDENTITY();

END
GO

CREATE PROCEDURE [dbo].[spInternetService_Insert]
@Name nvarchar(100),
@Speed nvarchar(100),
@CostPerMonth money,
@id int =0 output
AS
BEGIN

	SET NOCOUNT ON;
	INSERT INTO dbo.InternetService(Name,Speed,CostPerMonth)
	VALUES(@Name, @Speed, @CostPerMonth);
	SELECT @id = SCOPE_IDENTITY();

END
GO

CREATE PROCEDURE [dbo].[spTvService_Insert]
@Name nvarchar(100),
@ChannelCount int,
@CostPerMonth money,
@id int =0 output
AS
BEGIN

	SET NOCOUNT ON;
	INSERT INTO dbo.TvService(Name,ChannelCount,CostPerMonth)
	VALUES(@Name, @ChannelCount, @CostPerMonth);
	SELECT @id = SCOPE_IDENTITY();

END
GO

CREATE PROCEDURE [dbo].[spPhoneService_Insert]
@Name nvarchar(100),
@TalkingMinutes int,
@MessageAmount int,
@CostPerMonth money,
@id int =0 output
AS
BEGIN

	SET NOCOUNT ON;
	INSERT INTO dbo.PhoneService(Name,TalkingMinutes,MessageAmount,CostPerMonth)
	VALUES(@Name, @TalkingMinutes,@MessageAmount, @CostPerMonth);
	SELECT @id = SCOPE_IDENTITY();

END
GO

CREATE PROCEDURE [dbo].[spServicePackage_Insert]
@InternetServiceId int,
@InternetServiceDurationMonths int,
@InternetServiceStartingDate datetime,
@InternetServiceEndingDate datetime,
@TvServiceId int,
@TvServiceDurationMonths int,
@TvServiceStartingDate datetime,
@TvServiceEndingDate datetime,
@PhoneServiceId int,
@PhoneServiceDurationMonths int,
@PhoneServiceStartingDate datetime,
@PhoneServiceEndingDate datetime,
@id int =0 output
AS
BEGIN
	
	SET NOCOUNT ON;
	INSERT INTO dbo.ServicePackage(
									InternetServiceId,
									InternetServiceDurationMonths,
									InternetServiceStartingDate,
									InternetServiceEndingDate,
									TvServiceId,
									TvServiceDurationMonths,
									TvServiceStartingDate,
									TvServiceEndingDate,
									PhoneServiceId,
									PhoneServiceDurationMonths,
									PhoneServiceStartingDate,
									PhoneServiceEndingDate)
	VALUES(	                        @InternetServiceId,
									@InternetServiceDurationMonths, 
									@InternetServiceStartingDate,
									@InternetServiceEndingDate,
									@TvServiceId,
									@TvServiceDurationMonths,
									@TvServiceStartingDate,
									@TvServiceEndingDate,
									@PhoneServiceId,
									@PhoneServiceDurationMonths,
									@PhoneServiceStartingDate,
									@PhoneServiceEndingDate);
	SELECT @id = SCOPE_IDENTITY();

END
GO

CREATE PROCEDURE [dbo].[spInternetService_GetAll]
	
AS
BEGIN
select * from dbo.InternetService;
END
GO

CREATE PROCEDURE [dbo].[spPhoneService_GetAll]
	
AS
BEGIN
select * from dbo.PhoneService;
END
GO

CREATE PROCEDURE [dbo].[spTvService_GetAll]
	
AS
BEGIN
select * from dbo.TvService;
END
GO

CREATE PROCEDURE [dbo].[spInternetService_DeleteById]
@InternetServiceId int
AS
BEGIN
DELETE FROM dbo.InternetService
WHERE id = @InternetServiceId;
END
GO

CREATE PROCEDURE [dbo].[spTvService_DeleteById]
@TvServiceId int
AS
BEGIN
DELETE FROM dbo.TvService
WHERE id = @TvServiceId;
END
GO

CREATE PROCEDURE [dbo].[spPhoneService_DeleteById]
@PhoneServiceId int
AS
BEGIN
DELETE FROM dbo.PhoneService
WHERE id = @PhoneServiceId;
END
GO

CREATE PROCEDURE [dbo].[spCustomer_GetAll]
	
AS
BEGIN
select * from dbo.Customer;
END
GO


CREATE PROCEDURE [dbo].[spCustomer_GetByAddressNameAndNumber]
@AddressName nvarchar(200),
@AddressNumber int,
@ServicePackageId int output
AS
BEGIN

SELECT c.*
FROM Customer as c 
WHERE c.AddressName = @AddressName AND c.AddressNumber = @AddressNumber
SELECT @ServicePackageId = c.ServicePackageId
FROM Customer as c
WHERE c.AddressName = @AddressName AND c.AddressNumber = @AddressNumber
END
GO

CREATE PROCEDURE [dbo].[spServicePackage_GetById]
@ServicePackageId int,
@InternetServiceId int =0 output,
@TvServiceId int =0 output,
@PhoneServiceId int =0 output
AS
BEGIN
select * from dbo.ServicePackage
WHERE ServicePackage.id = @ServicePackageId;
select @InternetServiceId = s.InternetServiceId,@TvServiceId = s.TvServiceId, @PhoneServiceId = s.PhoneServiceId from dbo.ServicePackage as s
WHERE s.id = @ServicePackageId;
END
GO


CREATE PROCEDURE [dbo].[spInternetService_GetById]	
@InternetServiceId int
AS
BEGIN
select * from dbo.InternetService
WHERE InternetService.id = @InternetServiceId;
END
GO 

CREATE PROCEDURE [dbo].[spTvService_GetById]
@TvServiceId int
AS
BEGIN
select * from dbo.TvService
WHERE TvService.id = @TvServiceId;
END
GO 

CREATE PROCEDURE [dbo].[spPhoneService_GetById]
@PhoneServiceId int
AS
BEGIN
select * from dbo.PhoneService
WHERE PhoneService.id = @PhoneServiceId;
END
GO 


CREATE PROCEDURE [dbo].[spCustomer_DeleteById]
@id int
AS
BEGIN
DELETE FROM dbo.Customer
WHERE id = @id;
END
GO

CREATE PROCEDURE [dbo].[spServicePackage_Update]
@InternetServiceId int,
@InternetServiceDurationMonths int,
@InternetServiceStartingDate datetime,
@InternetServiceEndingDate datetime,
@TvServiceId int,
@TvServiceDurationMonths int,
@TvServiceStartingDate datetime,
@TvServiceEndingDate datetime,
@PhoneServiceId int,
@PhoneServiceDurationMonths int,
@PhoneServiceStartingDate datetime,
@PhoneServiceEndingDate datetime,
@id int =0 output
AS
BEGIN
	
	SET NOCOUNT ON;
	UPDATE dbo.ServicePackage
	SET InternetServiceId = @InternetServiceId,
		InternetServiceDurationMonths = @InternetServiceDurationMonths,
		InternetServiceStartingDate = @InternetServiceStartingDate,
		InternetServiceEndingDate = @InternetServiceEndingDate,
		TvServiceId = @TvServiceId,
		TvServiceDurationMonths = @TvServiceDurationMonths,
		TvServiceStartingDate = @TvServiceStartingDate,
		TvServiceEndingDate = @TvServiceEndingDate,
		PhoneServiceId = @PhoneServiceId,
		PhoneServiceDurationMonths = @PhoneServiceDurationMonths,
		PhoneServiceStartingDate = @PhoneServiceStartingDate,
		PhoneServiceEndingDate = @PhoneServiceEndingDate;
	SELECT @id = SCOPE_IDENTITY();

END
GO

CREATE PROCEDURE [dbo].[spCustomer_Update]
@CustomerId int,
@FirstName nvarchar(100),
@LastName nvarchar (100),
@AddressName nvarchar(200),
@AddressNumber int,
@PhoneNumber varchar (20),
@EmailAddress nvarchar (100),
@ServicePackageId int

AS
BEGIN

	SET NOCOUNT ON;
	UPDATE dbo.Customer
	SET FirstName = @FirstName,
		LastName = @LastName,	
		AddressName = @AddressName,
		AddressNumber = @AddressNumber,
		PhoneNumber = @PhoneNumber,
		EmailAddress = @EmailAddress,
		ServicePackageId = @ServicePackageId
	WHERE Customer.id = @CustomerId
END
GO



INSERT INTO dbo.InternetService(Name,Speed,CostPerMonth)
VALUES('Fiber50', 50, 999);
INSERT INTO dbo.InternetService(Name,Speed,CostPerMonth)
VALUES('Fiber100', 100, 1399);

INSERT INTO dbo.TvService(Name,ChannelCount,CostPerMonth)
VALUES('Total50', 50, 500);
INSERT INTO dbo.TvService(Name,ChannelCount,CostPerMonth)
VALUES('Total100', 100, 899);

INSERT INTO dbo.PhoneService(Name,TalkingMinutes,MessageAmount,CostPerMonth)
VALUES('Max50', 5000,500, 500);
INSERT INTO dbo.PhoneService(Name,TalkingMinutes,MessageAmount,CostPerMonth)
VALUES('Super 60', 6000,600, 600);







--TESTING
SELECT * FROM CUSTOMER as c
LEFT JOIN ServicePackage as s on c.id = s.id
LEFT JOIN InternetService as i on s.InternetServiceId = i.id
LEFT JOIN PhoneService as p on s.PhoneServiceId = p.id
LEFT JOIN TvService as t on s.TvServiceId = t.id
WHERE c.AddressName = 'Bitolska' AND c.AddressNumber = 64;

select * from dbo.ServicePackage
WHERE ServicePackage.id = 2;