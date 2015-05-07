--------------------------------------------------------------------------------------------------
--客运触摸管理系统
--
--版本：0.1

USE [kyz_bs]
GO

--------------------------------------------------------------------------------------------------
--ID卡号表
--xinqiao.liu(2010-03-10)
--------------------------------------------------------------------------------------------------
IF EXISTS (select * from dbo.sysobjects where id = object_id(N'[dbo].[IDCards]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)   
	DROP TABLE [dbo].[IDCards]   
GO

CREATE TABLE [dbo].[IDCards](
	[CID]			varchar(18)			NOT NULL,								--卡号
	[Name]			nvarchar(32)		NOT NULL default(''),					--卡号名称
	[Code]			varchar(8)			NOT NULL default(''),					--卡号代码
	[Money]			decimal(8,2)		NOT NULL,								--金额
	[CPH]			nvarchar(8)			NOT NULL,								--默认绑定车牌
	[IsAdmin]		nchar(1)			NOT NULL default('0'),					--是否为管理卡号
	[IsGroup]		nchar(1)			NOT NULL default('0'),					--是否为公司卡号
	[IsCycle]		nchar(1)			NOT NULL default('0'),					--是否为循环卡号
	[Lines]			nvarchar(32)		NOT NULL default(''),					--循环线路，可用引号间隔
	[CreateDT]		datetime			NOT NULL default(getdate()),			--创建时间
	
	CONSTRAINT [PK_IDCards] PRIMARY KEY CLUSTERED 
	(
		[CID] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--ID卡号绑定车牌表
--xinqiao.liu(2010-03-10)
--------------------------------------------------------------------------------------------------
IF EXISTS (select * from dbo.sysobjects where id = object_id(N'[dbo].[IDCardItems]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)   
	DROP TABLE [dbo].[IDCardItems]   
GO

CREATE TABLE [dbo].[IDCardItems](
	[SN]			int	IDENTITY(1,1)	NOT NULL,								--编号
	[CID]			varchar(18)			NOT NULL,								--卡号
	[CPH]			nvarchar(8)			NOT NULL,								--绑定车牌

	CONSTRAINT [PK_IDCardItems] PRIMARY KEY CLUSTERED 
	(
		[SN] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--添加CID外键约束
ALTER TABLE [dbo].[IDCardItems]  WITH CHECK ADD CONSTRAINT [FK_IDCardItems_IDCards] FOREIGN KEY([CID])
	REFERENCES [dbo].[IDCards] ([CID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[IDCardItems] CHECK CONSTRAINT [FK_IDCardItems_IDCards]
GO

--------------------------------------------------------------------------------------------------
--ID卡日志
--xinqiao.liu(2010-03-10)
--------------------------------------------------------------------------------------------------
IF EXISTS (select * from dbo.sysobjects where id = object_id(N'[dbo].[IDCardLog]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)   
	DROP TABLE [dbo].[IDCardLog]   
GO

CREATE TABLE [dbo].[IDCardLog](
	[SN]			int	IDENTITY(1,1)	NOT NULL,								--编号
	[Type]			nvarchar(8)			NOT NULL,								--日志类型（登录、签到及查询等）
	[CID]			varchar(18)			NOT NULL,								--卡号
	[CPH]			nvarchar(8)			NOT NULL,								--车牌
	[RQ]			datetime			NOT NULL,								--班次日期
	[CC]			varchar(8)			NOT NULL,								--班次编号
	[CreateDT]		datetime			NOT NULL default(getdate()),			--创建时间

	CONSTRAINT [PK_IDCardLog] PRIMARY KEY CLUSTERED 
	(
		[SN] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--ID卡支付
--xinqiao.liu(2010-03-10)
--------------------------------------------------------------------------------------------------
IF EXISTS (select * from dbo.sysobjects where id = object_id(N'[dbo].[IDCardPay]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)   
	DROP TABLE [dbo].[IDCardPay]   
GO

CREATE TABLE [dbo].[IDCardPay](
	[SN]			int	IDENTITY(1,1)	NOT NULL,								--编号
	[CID]			varchar(18)			NOT NULL,								--支付卡号
	[Money]			decimal(8,2)		NOT NULL,								--支付金额
	[Context]		nvarchar(32)		NOT NULL,								--支付说明
	[CreateDT]		datetime			NOT NULL default(getdate()),			--支付时间

	CONSTRAINT [PK_IDCardPay] PRIMARY KEY CLUSTERED 
	(
		[SN] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO