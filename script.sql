USE [master]
GO
/****** Object:  Database [Inventory]    Script Date: 8/24/2019 6:26:18 PM ******/
CREATE DATABASE [Inventory]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Inventory', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Inventory.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Inventory_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Inventory_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Inventory] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Inventory].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Inventory] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Inventory] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Inventory] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Inventory] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Inventory] SET ARITHABORT OFF 
GO
ALTER DATABASE [Inventory] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Inventory] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Inventory] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Inventory] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Inventory] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Inventory] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Inventory] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Inventory] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Inventory] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Inventory] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Inventory] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Inventory] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Inventory] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Inventory] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Inventory] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Inventory] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Inventory] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Inventory] SET RECOVERY FULL 
GO
ALTER DATABASE [Inventory] SET  MULTI_USER 
GO
ALTER DATABASE [Inventory] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Inventory] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Inventory] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Inventory] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Inventory] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Inventory', N'ON'
GO
ALTER DATABASE [Inventory] SET QUERY_STORE = OFF
GO
USE [Inventory]
GO
/****** Object:  Table [dbo].[categories]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[cat_id] [int] IDENTITY(1,1) NOT NULL,
	[cat_name] [varchar](50) NOT NULL,
	[cat_isActive] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](max) NULL,
	[role] [varchar](max) NULL,
	[password] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productPrice]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productPrice](
	[pp_proID] [int] NOT NULL,
	[pp_buyingPrice] [money] NOT NULL,
	[pp_sellingPrice] [money] NULL,
	[pp_discount] [float] NULL,
	[pp_profitPercentage] [float] NULL,
UNIQUE NONCLUSTERED 
(
	[pp_proID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[pro_id] [int] IDENTITY(1,1) NOT NULL,
	[pro_name] [varchar](50) NOT NULL,
	[pro_barcode] [nvarchar](100) NOT NULL,
	[pro_expiry] [date] NULL,
	[pro_catID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[pro_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [barcodeUnique] UNIQUE NONCLUSTERED 
(
	[pro_barcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [uniqueProduct] UNIQUE NONCLUSTERED 
(
	[pro_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchase]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchase](
	[p_id] [bigint] IDENTITY(1,1) NOT NULL,
	[p_date] [date] NOT NULL,
	[p_doneBy] [int] NOT NULL,
	[p_suppID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[p_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchase_details]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchase_details](
	[pid_id] [bigint] IDENTITY(1,1) NOT NULL,
	[pid_purchaseID] [bigint] NOT NULL,
	[pid_proID] [int] NOT NULL,
	[pid_proQuan] [int] NOT NULL,
	[pid_totprice] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[pid_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sales]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales](
	[sal_id] [bigint] IDENTITY(1,1) NOT NULL,
	[sal_doneBy] [int] NOT NULL,
	[sal_date] [datetime] NOT NULL,
	[sal_totAmt] [float] NOT NULL,
	[sal_totDis] [float] NULL,
	[sal_amtGiven] [float] NULL,
	[sal_amtReturn] [float] NULL,
	[sal_payType] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[sal_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesDetails]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesDetails](
	[sd_salID] [bigint] NOT NULL,
	[sd_proID] [bigint] NOT NULL,
	[sd_quan] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stock]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock](
	[st_proID] [int] NOT NULL,
	[st_quan] [int] NOT NULL,
UNIQUE NONCLUSTERED 
(
	[st_proID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[supplier]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supplier](
	[sup_id] [int] IDENTITY(1,1) NOT NULL,
	[sup_company] [varchar](100) NOT NULL,
	[sup_contactPerson] [varchar](50) NOT NULL,
	[sup_phone1] [varchar](15) NOT NULL,
	[sup_phone2] [varchar](15) NULL,
	[sup_address] [nvarchar](100) NOT NULL,
	[sup_ntn] [varchar](25) NOT NULL,
	[sup_status] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[sup_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[sup_company] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[trackDeletedItemPI]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trackDeletedItemPI](
	[p_id] [bigint] NOT NULL,
	[usr_id] [int] NOT NULL,
	[pro_id] [int] NOT NULL,
	[pro_quan] [int] NOT NULL,
	[del_date] [date] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[productPrice]  WITH CHECK ADD FOREIGN KEY([pp_proID])
REFERENCES [dbo].[products] ([pro_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK__products__pro_ca__49C3F6B7] FOREIGN KEY([pro_catID])
REFERENCES [dbo].[categories] ([cat_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK__products__pro_ca__49C3F6B7]
GO
ALTER TABLE [dbo].[purchase_details]  WITH CHECK ADD FOREIGN KEY([pid_purchaseID])
REFERENCES [dbo].[purchase] ([p_id])
GO
ALTER TABLE [dbo].[SalesDetails]  WITH CHECK ADD FOREIGN KEY([sd_salID])
REFERENCES [dbo].[sales] ([sal_id])
GO
ALTER TABLE [dbo].[trackDeletedItemPI]  WITH CHECK ADD FOREIGN KEY([pro_id])
REFERENCES [dbo].[products] ([pro_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
/****** Object:  StoredProcedure [dbo].[dashSup]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[dashSup]
as
select
s.sup_id as 'Supplier ID'
from 
supplier s
where s.sup_id=(select top 1 sr.sup_id from supplier sr order by sr.sup_id desc)
order by s.sup_id desc
GO
/****** Object:  StoredProcedure [dbo].[deletedPurchaseItems]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[deletedPurchaseItems]
as
select
p.p_id as 'Purchase ID',
td.usr_id as 'User ID',
td.pro_id as 'Product ID',
td.pro_quan as 'Product Quantity',
td.del_date as 'Delete Date'
from trackDeletedItemPI td
inner join purchase p
on td.p_id=p.p_id
GO
/****** Object:  StoredProcedure [dbo].[getPurchase]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getPurchase]
@date date 
as 
select distinct
prr.p_id as 'Purchase ID',
sup.sup_company as 'Company Name',
p.pro_barcode as 'Barcode',
p.pro_name as 'Product Name',
prop.pp_buyingPrice as 'Product Price',
pp.pid_proQuan as 'Product Quantity',
pp.pid_totprice as 'Total Price'
from purchase prr  inner join
purchase_details pp
on prr.p_id=pp.pid_purchaseID
inner join products p
on p.pro_id=pp.pid_proID
inner join supplier sup
on sup.sup_id=prr.p_suppID
inner join productPrice prop
on prop.pp_proID=p.pro_id

where convert(date, prr.p_date)=@date
GO
/****** Object:  StoredProcedure [dbo].[insertsales]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertsales]
@done int,
@date datetime,
@totamt float,
@totdis float,
@given float,
@return float,
@pyType tinyint --0 means cash 1 means debit 2 means credit card
as 
insert into sales values (@done,@date,@totamt,@totdis,@given,@return,@pyType)
GO
/****** Object:  StoredProcedure [dbo].[profitlossFrame]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[profitlossFrame]
as
select
sum(pds.pid_totprice) as 'Product buying Price',
sum(s.sal_totAmt) as 'Product Selling Price'
from 
stock stk
 inner join SalesDetails sd
on stk.st_proID=sd.sd_proID
inner join productPrice pp
on sd.sd_proID=pp.pp_proID
inner join sales s
on s.sal_id=sd.sd_salID
inner join purchase_details pds
on pds.pid_proID=pp.pp_proID
GO
/****** Object:  StoredProcedure [dbo].[purchaseReport]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[purchaseReport]
as 
select
prr.p_id as 'Purchase ID',
sup.sup_company as 'Company Name',
p.pro_barcode as 'Barcode',
p.pro_name as 'Product Name',
format(prr.p_date,'dd-MMM-yyyy hh:mm:ss tt') as 'Date',
prop.pp_buyingPrice as 'Product Price',
pp.pid_proQuan as 'Product Quantity',
pp.pid_totprice as 'Total Price'
from purchase prr  inner join
purchase_details pp
on prr.p_id=pp.pid_purchaseID
inner join products p
on p.pro_id=pp.pid_proID
inner join supplier sup
on sup.sup_id=prr.p_suppID
inner join productPrice prop
on prop.pp_proID=p.pro_id
where prr.p_id = (select top 1 pe.p_id from purchase pe order by pe.p_id desc)
order by prr.p_id desc
GO
/****** Object:  StoredProcedure [dbo].[purchaseReportWRTPurchaseID]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[purchaseReportWRTPurchaseID]
@purchaseID bigint
as 
select
prr.p_id as 'Purchase ID',
sup.sup_company as 'Company Name',
p.pro_barcode as 'Barcode',
p.pro_name as 'Product Name',
format(prr.p_date,'dd-MMM-yyyy hh:mm:ss tt') as 'Date',
prop.pp_buyingPrice as 'Product Price',
pp.pid_proQuan as 'Product Quantity',
pp.pid_totprice as 'Total Price'
from purchase prr  inner join
purchase_details pp
on prr.p_id=pp.pid_purchaseID
inner join products p
on p.pro_id=pp.pid_proID
inner join supplier sup
on sup.sup_id=prr.p_suppID
inner join productPrice prop
on prop.pp_proID=p.pro_id
where prr.p_id = @purchaseID
order by prr.p_id desc
GO
/****** Object:  StoredProcedure [dbo].[st_checkProductPriceExist]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_checkProductPriceExist]
@proID bigint
as 
select * from productPrice where pp_proID=@proID
GO
/****** Object:  StoredProcedure [dbo].[st_deleteCategory]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_deleteCategory]
@id int
as
delete from categories where cat_id=@id
GO
/****** Object:  StoredProcedure [dbo].[st_deleteProductFromPID]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_deleteProductFromPID]
@mPID bigint
as
delete from purchase_details
where pid_id=@mPID
GO
/****** Object:  StoredProcedure [dbo].[st_deleteSupplier]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_deleteSupplier]
@suppID int
as
delete from supplier where sup_id=@suppID
GO
/****** Object:  StoredProcedure [dbo].[st_getAllStock]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getAllStock]
as
select
p.pro_id as 'Product ID',
p.pro_name as'Product',
p.pro_barcode as 'Barcode',
format (p.pro_expiry,'dd-MMM-yyyy')as 'Expiry Date',
pp.pp_buyingPrice as'Buying Price',
pp.pp_sellingPrice as 'Selling Price',
c.cat_name as 'Category',
s.st_quan as'Available Stock',
case when (s.st_quan<200)then 'LOW'else case when(s.st_quan<1000 and s.st_quan>200)then 'Average' else case when (s.st_quan>=1000)then'Good' end end end as'Status',
pp.pp_buyingPrice*s.st_quan as 'Total Amount'
from stock s
inner join products p
on p.pro_id=s.st_proID
inner join categories c
on c.cat_id=p.pro_catID
inner join productPrice pp
on p.pro_id=pp.pp_proID

GO
/****** Object:  StoredProcedure [dbo].[st_getCatDataLIKE]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getCatDataLIKE]
@data varchar(50)
as
select
c.cat_id as 'ID',
c.cat_name as 'Name',
case when (cat_isActive=1) then 'Active' else 'In-active' end as 'Status'
from categories c
where
c.cat_name like '%'+@data+'%'
order by c.cat_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getCategoriesData]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getCategoriesData]
as
select
c.cat_id as 'ID',
c.cat_name as 'Category',
case when (c.cat_isActive=1) then 'Yes' else 'No' end as 'Status'
from categories c
order by c.cat_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getCategoriesList]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getCategoriesList]
as
select c.cat_id as 'ID',
c.cat_name as 'Category'
from categories c
order by c.cat_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getLastPurchaseID]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getLastPurchaseID]
as
select top 1 pu.p_id from purchase pu order by pu.p_id desc
GO
/****** Object:  StoredProcedure [dbo].[st_getProductByBarcode]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getProductByBarcode]
@barcode nvarchar(100)
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
p.pro_barcode as 'Barcode',
pp.pp_sellingPrice as 'Selling Price',
pp.pp_sellingPrice*pp.pp_discount/100 'Discount',
pp.pp_sellingPrice-(pp.pp_sellingPrice*pp.pp_discount/100) as 'Final Selling Price'
from products p 
left join productPrice pp
on p.pro_id=pp.pp_proID
where p.pro_barcode=@barcode
GO
/****** Object:  StoredProcedure [dbo].[st_getProductByBarcodeSales]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getProductByBarcodeSales]
@barcode nvarchar(100)
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
p.pro_barcode as 'Barcode',
pp.pp_sellingPrice as 'Selling Price',
pp.pp_sellingPrice*pp.pp_discount/100 'Discount',
pp.pp_sellingPrice-(pp.pp_sellingPrice*pp.pp_discount/100) as 'Final Selling Price'
from products p 
inner join productPrice pp
on p.pro_id=pp.pp_proID
where p.pro_barcode=@barcode
GO
/****** Object:  StoredProcedure [dbo].[st_getProductQuantity]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getProductQuantity]
@proID bigint
as
select s.st_quan as 'Quantity' from stock s where s.st_proID=@proID
GO
/****** Object:  StoredProcedure [dbo].[st_getProductsData]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getProductsData]
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
FORMAT(p.pro_expiry,'dd-MMM-yyyy') as 'Expiry',
p.pro_barcode as 'Barcode',
c.cat_name as 'Category',
c.cat_id as 'Category ID'
from products p
inner join  categories c
on c.cat_id=p.pro_catID
GO
/****** Object:  StoredProcedure [dbo].[st_getProductWRTCategory]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getProductWRTCategory]
@catID int
as 
select
p.pro_id as'Product ID',
p.pro_name as'Product',
pp.pp_buyingPrice as 'Buying Price',
case when (pp.pp_sellingPrice is null) then 0 else pp.pp_sellingPrice end as'Selling Price',
case when (pp.pp_discount is null) then 0 else pp.pp_discount end as'Discount',
case when (pp.pp_profitPercentage is null) then 0 else pp.pp_profitPercentage end as 'Profit Percentage'
from products p
inner join productPrice pp
on p.pro_id=pp.pp_proID
inner join categories c
on c.cat_id=p.pro_catID
where c.cat_id=@catID
GO
/****** Object:  StoredProcedure [dbo].[st_getPurchaseDetails]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getPurchaseDetails]
@pid bigint
as
select
pid.pid_id as 'mPID',
pid.pid_proID as 'Product ID',
p.pro_name as'Product',
pid.pid_proQuan as 'Quantity',
pid.pid_totprice as 'Total Price',
pp.pp_buyingPrice as 'Per Unit Price'
from purchase pii
inner join purchase_details pid
inner join products p on p.pro_id=pid.pid_proID
on pii.p_id =pid.pid_purchaseID
inner join productPrice pp
on p.pro_id=pp.pp_proID
where pii.p_id=@pid
GO
/****** Object:  StoredProcedure [dbo].[st_getPurchaseList]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getPurchaseList]
@month int,
@year int
as 
select
pii.p_id as'ID',
su.sup_company+' '+FORMAT(pii.p_date,'dd-MMM-yyyy') as'Company'
from purchase pii
inner join supplier su
on su.sup_id=pii.p_suppID
where 
MONTH(pii.p_date)=@month and year(pii.p_date)=@year
GO
/****** Object:  StoredProcedure [dbo].[st_getSales]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getSales]
@date date 
as 
select distinct
s.sal_id as 'Sales id',
sd.sd_salID as 'Salesman id',
s.sal_totAmt as 'Total Amount',
s.sal_amtGiven as 'Amount Given',
s.sal_amtReturn as 'Amount Return',
s.sal_totDis as 'Total Discount'
from sales s inner join 
SalesDetails sd
on s.sal_id = sd.sd_salID
where convert(date, s.sal_date)=@date
GO
/****** Object:  StoredProcedure [dbo].[st_getSalesID]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getSalesID]
as 
select top 1 s.sal_id as 'Sales ID' from sales s order by s.sal_id desc
GO
/****** Object:  StoredProcedure [dbo].[st_getSalesReceipt]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getSalesReceipt]
as
select 
s.sal_id as 'Sales ID',
p.pro_barcode as 'Barcode',
p.pro_name as 'Product',
sd.sd_quan as 'Quantity',
s.sal_totDis as 'Total Discount',
s.sal_totAmt as 'Total Amount',
s.sal_amtGiven as 'Amount Given',
s.sal_amtReturn as 'Amount Returned',
format(s.sal_date,'dd-MMM-yyyy hh:mm:ss tt') as 'Date',
pp.pp_sellingPrice as'Product price',
(pp.pp_sellingPrice*pp.pp_discount/100)*sd.sd_quan as 'Per Product Discount',
(pp.pp_sellingPrice+sd.sd_quan)-((pp.pp_sellingPrice*pp.pp_discount/100)* sd.sd_quan ) as 'Per Product Total',
case when (s.sal_payType=0) then 'Cash' else case when (s.sal_payType=1) then 'Debit Card' else case when (s.sal_payType=2) then 'Credit Card' end end end as 'Pay Type'
from sales s inner join
SalesDetails sd
on s.sal_id=sd.sd_salID
inner join products p
on p.pro_id=sd.sd_proID
inner join productPrice pp
on pp.pp_proID=p.pro_id
where s.sal_id = (select top 1 ss.sal_id from sales ss order by ss.sal_id desc)
order by s.sal_id desc
GO
/****** Object:  StoredProcedure [dbo].[st_getSalesReceiptWRTSalesID]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getSalesReceiptWRTSalesID]
@salesID bigint 
as
select 
s.sal_id as 'Sales ID',
p.pro_barcode as 'Barcode',
p.pro_name as 'Product',
sd.sd_quan as 'Quantity',
s.sal_totDis as 'Total Discount',
s.sal_totAmt as 'Total Amount',
s.sal_amtGiven as 'Amount Given',
s.sal_amtReturn as 'Amount Returned',
format(s.sal_date,'dd-MMM-yyyy hh:mm:ss tt') as 'Date',
pp.pp_sellingPrice as'Product price',
(pp.pp_sellingPrice*pp.pp_discount/100)*sd.sd_quan as 'Per Product Discount',
(pp.pp_sellingPrice+sd.sd_quan)-((pp.pp_sellingPrice*pp.pp_discount/100)* sd.sd_quan ) as 'Per Product Total',
case when (s.sal_payType=1) then 'Cash' else case when (s.sal_payType=2) then 'Debit Card' else case when (s.sal_payType=3) then 'Credit Card' end end end as 'Pay Type'
from sales s inner join
SalesDetails sd
on s.sal_id=sd.sd_salID
inner join products p
on p.pro_id=sd.sd_proID
inner join productPrice pp
on pp.pp_proID=p.pro_id
where s.sal_id = @salesID
order by s.sal_id desc
GO
/****** Object:  StoredProcedure [dbo].[st_getStock]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getStock]
@date date 
as
select distinct
prr.p_id as 'Purchase ID',
p.pro_name as 'Product Name',
p.pro_barcode as 'Barcode',
format (p.pro_expiry,'dd-MMM-yyyy')as 'Expiry Date',
prop.pp_buyingPrice as 'Buying Price',
format(prr.p_date,'dd-MMM-yyyy hh:mm:ss tt') as 'Date',
pp.pid_proQuan as 'Quantity',
prop.pp_sellingPrice as 'SPrice',
stk.st_quan as 'Avaliable Stock',
case when (stk.st_quan<200)then 'LOW'else case when(stk.st_quan<1000 and stk.st_quan>200)then 'Average' else case when (stk.st_quan>=1000)then'Good' end end end as'Status',
prop.pp_buyingPrice*stk.st_quan as 'Total Amount'
from purchase prr  inner join
purchase_details pp
on prr.p_id=pp.pid_purchaseID
inner join products p
on p.pro_id=pp.pid_proID
inner join stock stk
on stk.st_proID=pp.pid_proID
inner join productPrice prop
on prop.pp_proID=p.pro_id
where convert(date, prr.p_date)=@date
GO
/****** Object:  StoredProcedure [dbo].[st_getSupplierData]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getSupplierData]
as
select
s.sup_id as 'ID',
s.sup_company as 'Company',
s.sup_contactPerson as 'Contact Person',
s.sup_phone1 as 'Phone 1',
s.sup_phone2 as 'Phone 2',
s.sup_ntn as 'NTN #',
s.sup_address as 'Address',
case when (s.sup_status=1) then 'Active' else 'In-active' end as 'Status'
from supplier s order by s.sup_company asc
GO
/****** Object:  StoredProcedure [dbo].[st_getSupplierList]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getSupplierList]
as
select s.sup_id as 'ID',s.sup_company as 'Company' from supplier s where s.sup_status = 1 order by s.sup_company asc
GO
/****** Object:  StoredProcedure [dbo].[st_insertCategory]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_insertCategory]
@name varchar(50),
@isActive tinyint
as
insert into categories values (@name,@isActive)
GO
/****** Object:  StoredProcedure [dbo].[st_insertDeletedItemPI]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_insertDeletedItemPI]
@pi bigint,
@usrID int,
@proID bigint,
@quan int,
@date date
as
insert into trackDeletedItemPI values (@pi,@usrID,@proID,@quan,@date)
GO
/****** Object:  StoredProcedure [dbo].[st_insertProductPrice]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_insertProductPrice]
@proID bigint,
@bp money
as 
insert into productPrice(pp_proID,pp_buyingPrice) values(@proID,@bp)
GO
/****** Object:  StoredProcedure [dbo].[st_insertPurchase]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_insertPurchase]
@date date,
@doneBy int,
@suppID int
as
insert into purchase values (@date,@doneBy,@suppID)
GO
/****** Object:  StoredProcedure [dbo].[st_insertPurchaseDetails]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_insertPurchaseDetails]
@purchaseID bigint,
@proID int,
@Quan int,
@totPrice money
as 
insert into purchase_details values (@purchaseID,@proID,@Quan,@totPrice)
GO
/****** Object:  StoredProcedure [dbo].[st_insertSalesDetails]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_insertSalesDetails]
@salID bigint,
@proID bigint,
@quan int
as 
insert into SalesDetails values (@salID,@proID,@quan)
GO
/****** Object:  StoredProcedure [dbo].[st_insertStock]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_insertStock]
@proID bigint,
@quan int
as 
insert into stock values (@proID,@quan)
GO
/****** Object:  StoredProcedure [dbo].[st_insertSupplier]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_insertSupplier]
@company varchar(100),
@conPerson varchar(50),
@phone1 varchar(15),
@phone2 varchar(15),
@address nvarchar(100),
@ntn varchar(25),
@status tinyint
as
insert into supplier values (@company,@conPerson,@phone1,@phone2,@address,@ntn,@status)
GO
/****** Object:  StoredProcedure [dbo].[st_productDelete]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_productDelete]
@proID int
as
delete from products where pro_id=@proID

GO
/****** Object:  StoredProcedure [dbo].[st_productInsert]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_productInsert]
@name varchar(50),
@barcode nvarchar(100),
@expiry date,
@catID int
as
insert into products values (@name,@barcode,@expiry,@catID)
GO
/****** Object:  StoredProcedure [dbo].[st_productUpdate]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_productUpdate]
@name varchar(50),
@barcode nvarchar(100),
@expiry date,
@catID int,
@proID bigint
as
update products
set
pro_name =@name,
pro_expiry=@expiry,
pro_catID=@catID,
pro_barcode=@barcode
where
pro_id=@proID

GO
/****** Object:  StoredProcedure [dbo].[st_updateCategory]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_updateCategory]
@name varchar(50),
@isActive tinyint,
@id int
as
update categories
set
cat_name=@name,
cat_isActive =@isActive
where
cat_id=@id
GO
/****** Object:  StoredProcedure [dbo].[st_updateProductPrice]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_updateProductPrice]
@proID bigint,
@bp money,
@sp money,
@dis float,
@profper float
as
update productPrice
set
pp_buyingPrice=@bp,
pp_sellingPrice=@sp,
pp_discount=@dis,
pp_profitPercentage=@profper
where
pp_proID=@proID
GO
/****** Object:  StoredProcedure [dbo].[st_updateProductPrice1]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_updateProductPrice1]
@proID bigint,
@bp money
as
update productPrice
set
pp_buyingPrice=@bp
where
pp_proID=@proID
GO
/****** Object:  StoredProcedure [dbo].[st_updatestock]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_updatestock]
@quan int,
@proID int
as 
update stock
set st_quan=@quan
where
st_proID=@proID
GO
/****** Object:  StoredProcedure [dbo].[st_updateSupplier]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_updateSupplier]
@company varchar(100),
@conPerson varchar(50),
@phone1 varchar(15),
@phone2 varchar(15),
@address nvarchar(100),
@ntn varchar(25),
@status tinyint,
@suppID int
as
update supplier
set
sup_company=@company,
sup_contactPerson=@conPerson,
sup_phone1=@phone1,
sup_phone2=@phone2,
sup_address=@address,
sup_ntn=@ntn,
sup_status=@status
where
sup_id=@suppID
GO
/****** Object:  StoredProcedure [dbo].[StockReport]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[StockReport]
as
select
prr.p_id as 'Purchase ID',
p.pro_name as 'Product Name',
p.pro_barcode as 'Barcode',
format (p.pro_expiry,'dd-MMM-yyyy')as 'Expiry Date',
prop.pp_buyingPrice as 'Buying Price',
format(prr.p_date,'dd-MMM-yyyy hh:mm:ss tt') as 'Date',
prop.pp_buyingPrice as 'Price',
pp.pid_proQuan as 'Quantity',
prop.pp_sellingPrice as 'Price',
stk.st_quan as 'Avaliable Stock',
case when (stk.st_quan<200)then 'LOW'else case when(stk.st_quan<1000 and stk.st_quan>200)then 'Average' else case when (stk.st_quan>=1000)then'Good' end end end as'Status',
prop.pp_buyingPrice*stk.st_quan as 'Total Amount'
from purchase prr  inner join
purchase_details pp
on prr.p_id=pp.pid_purchaseID
inner join products p
on p.pro_id=pp.pid_proID
inner join supplier sup
on sup.sup_id=prr.p_suppID
inner join stock stk
on stk.st_proID=p.pro_id
inner join productPrice prop
on prop.pp_proID=p.pro_id
where prr.p_id = (select top 1 pe.p_id from purchase pe order by pe.p_id desc)
order by prr.p_id desc
GO
/****** Object:  StoredProcedure [dbo].[updatesStockWRTpurchaseID]    Script Date: 8/24/2019 6:26:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[updatesStockWRTpurchaseID]
@purchaseID bigint
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product Name',
p.pro_barcode as 'Barcode',
format (p.pro_expiry,'dd-MMM-yyyy')as 'Expiry Date',
prop.pp_buyingPrice as 'Buying Price',
format(prr.p_date,'dd-MMM-yyyy hh:mm:ss tt') as 'Date',
prop.pp_buyingPrice as 'Price',
pp.pid_proQuan as 'Quantity',
prop.pp_sellingPrice as 'Price',
stk.st_quan as 'Avaliable Stock',
case when (stk.st_quan<200)then 'LOW'else case when(stk.st_quan<1000 and stk.st_quan>200)then 'Average' else case when (stk.st_quan>=1000)then'Good' end end end as'Status',
prop.pp_buyingPrice*stk.st_quan as 'Total Amount'
from purchase prr  inner join
purchase_details pp
on prr.p_id=pp.pid_purchaseID
inner join products p
on p.pro_id=pp.pid_proID
inner join supplier sup
on sup.sup_id=prr.p_suppID
inner join stock stk
on stk.st_proID=p.pro_id
inner join productPrice prop
on prop.pp_proID=p.pro_id
where prr.p_id = @purchaseID
order by prr.p_id desc
GO
USE [master]
GO
ALTER DATABASE [Inventory] SET  READ_WRITE 
GO
