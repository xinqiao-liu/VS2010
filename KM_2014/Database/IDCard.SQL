--------------------------------------------------------------------------------------------------
--���˴�������ϵͳ
--
--�汾��0.1

USE [kyz_bs]
GO

--------------------------------------------------------------------------------------------------
--ID���ű�
--xinqiao.liu(2010-03-10)
--------------------------------------------------------------------------------------------------
IF EXISTS (select * from dbo.sysobjects where id = object_id(N'[dbo].[IDCards]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)   
	DROP TABLE [dbo].[IDCards]   
GO

CREATE TABLE [dbo].[IDCards](
	[CID]			varchar(18)			NOT NULL,								--����
	[Name]			nvarchar(32)		NOT NULL default(''),					--��������
	[Code]			varchar(8)			NOT NULL default(''),					--���Ŵ���
	[Money]			decimal(8,2)		NOT NULL,								--���
	[CPH]			nvarchar(8)			NOT NULL,								--Ĭ�ϰ󶨳���
	[IsAdmin]		nchar(1)			NOT NULL default('0'),					--�Ƿ�Ϊ��������
	[IsGroup]		nchar(1)			NOT NULL default('0'),					--�Ƿ�Ϊ��˾����
	[IsCycle]		nchar(1)			NOT NULL default('0'),					--�Ƿ�Ϊѭ������
	[Lines]			nvarchar(32)		NOT NULL default(''),					--ѭ����·���������ż��
	[CreateDT]		datetime			NOT NULL default(getdate()),			--����ʱ��
	
	CONSTRAINT [PK_IDCards] PRIMARY KEY CLUSTERED 
	(
		[CID] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--ID���Ű󶨳��Ʊ�
--xinqiao.liu(2010-03-10)
--------------------------------------------------------------------------------------------------
IF EXISTS (select * from dbo.sysobjects where id = object_id(N'[dbo].[IDCardItems]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)   
	DROP TABLE [dbo].[IDCardItems]   
GO

CREATE TABLE [dbo].[IDCardItems](
	[SN]			int	IDENTITY(1,1)	NOT NULL,								--���
	[CID]			varchar(18)			NOT NULL,								--����
	[CPH]			nvarchar(8)			NOT NULL,								--�󶨳���

	CONSTRAINT [PK_IDCardItems] PRIMARY KEY CLUSTERED 
	(
		[SN] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--����CID���Լ��
ALTER TABLE [dbo].[IDCardItems]  WITH CHECK ADD CONSTRAINT [FK_IDCardItems_IDCards] FOREIGN KEY([CID])
	REFERENCES [dbo].[IDCards] ([CID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[IDCardItems] CHECK CONSTRAINT [FK_IDCardItems_IDCards]
GO

--------------------------------------------------------------------------------------------------
--ID����־
--xinqiao.liu(2010-03-10)
--------------------------------------------------------------------------------------------------
IF EXISTS (select * from dbo.sysobjects where id = object_id(N'[dbo].[IDCardLog]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)   
	DROP TABLE [dbo].[IDCardLog]   
GO

CREATE TABLE [dbo].[IDCardLog](
	[SN]			int	IDENTITY(1,1)	NOT NULL,								--���
	[Type]			nvarchar(8)			NOT NULL,								--��־���ͣ���¼��ǩ������ѯ�ȣ�
	[CID]			varchar(18)			NOT NULL,								--����
	[CPH]			nvarchar(8)			NOT NULL,								--����
	[RQ]			datetime			NOT NULL,								--�������
	[CC]			varchar(8)			NOT NULL,								--��α��
	[CreateDT]		datetime			NOT NULL default(getdate()),			--����ʱ��

	CONSTRAINT [PK_IDCardLog] PRIMARY KEY CLUSTERED 
	(
		[SN] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--ID��֧��
--xinqiao.liu(2010-03-10)
--------------------------------------------------------------------------------------------------
IF EXISTS (select * from dbo.sysobjects where id = object_id(N'[dbo].[IDCardPay]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)   
	DROP TABLE [dbo].[IDCardPay]   
GO

CREATE TABLE [dbo].[IDCardPay](
	[SN]			int	IDENTITY(1,1)	NOT NULL,								--���
	[CID]			varchar(18)			NOT NULL,								--֧������
	[Money]			decimal(8,2)		NOT NULL,								--֧�����
	[Context]		nvarchar(32)		NOT NULL,								--֧��˵��
	[CreateDT]		datetime			NOT NULL default(getdate()),			--֧��ʱ��

	CONSTRAINT [PK_IDCardPay] PRIMARY KEY CLUSTERED 
	(
		[SN] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO