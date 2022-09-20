create database Shopping_DB

CREATE TABLE [dbo].[RoleDetails](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[UserDetails](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Username] [varchar](50) NOT NULL,
    [Email] [varchar](70) NOT NULL,
    [Password] [varchar](50) NOT NULL,
    [Address] [varchar](50) NULL,
    [Contactno] [bigint] NULL,
    [Role] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UserDetails]  WITH CHECK ADD FOREIGN KEY([Role])
REFERENCES [dbo].[RoleDetails] ([Id])
GO




CREATE TABLE [dbo].[ProductDetails](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Sellerid] [int] NOT NULL,
    [Name] [varchar](50) NOT NULL,
    [Description] [varchar](50) NULL,
    [Category] [varchar](50) NOT NULL,
    [Gender] [varchar](20) NOT NULL,
    [Price] [decimal](10, 4) NOT NULL,
    [Discount] [int] NULL,
    [Publish] [datetime] NULL,
    [Imageurl] [nvarchar](max) NULL,
    [Size] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ProductDetails]  WITH CHECK ADD FOREIGN KEY([Sellerid])
REFERENCES [dbo].[UserDetails] ([Id])
GO




CREATE TABLE [dbo].[CartDetails](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Productid] [int] NOT NULL,
    [Customerid] [int] NOT NULL,
    [Quantity] [int] NULL,
    [Visible] [int] NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CartDetails]  WITH CHECK ADD FOREIGN KEY([Customerid])
REFERENCES [dbo].[UserDetails] ([Id])
GO

ALTER TABLE [dbo].[CartDetails]  WITH CHECK ADD FOREIGN KEY([Productid])
REFERENCES [dbo].[ProductDetails] ([Id])
GO


CREATE TABLE [dbo].[Paymentdetails](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Userid] [int] NOT NULL,
    [Productid] [int] NOT NULL,
    [Quantity] [int] NULL,
    [Name] [varchar](50) NOT NULL,
    [Address] [varchar](50) NULL,
    [Email] [varchar](20) NOT NULL,
    [Mobileno] [bigint] NOT NULL,
    [Totalamount] [decimal](10, 4) NULL,
    [Orderdate] [datetime] NULL,
    [Paymentmode] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE Procedure [dbo].[GetCartDetail]
as
begin
select c.Id, c.Customerid,c.Quantity,c.Productid,c.Visible,p.Name,p.Price,p.Discount,p.Imageurl,p.Size from ProductDetails as p inner join CartDetails as c on  p.Id=c.Productid
end
GO

Insert into RoleDetails values('buyer')
Insert into RoleDetails values('seller')