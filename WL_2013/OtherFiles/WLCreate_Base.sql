--------------------------------------------------------------------------------------------------
--��·������������ϵͳ���ڵ����ݿ⣩
--
--�汾��2013.06.5
--

--------------------------------------------------------------------------------------------------
--�������ݿ�
--------------------------------------------------------------------------------------------------

SET NOCOUNT ON
GO

USE master
GO

--������ݿ��Ƿ���ڣ����������ɾ��
IF EXISTS(SELECT * FROM sysdatabases WHERE name='wlserver')
	DROP DATABASE wlserver
GO

--���������ݿ��ļ��洢Ŀ¼
DECLARE @device_directory NVARCHAR(520)
--SELECT @device_directory = 'D:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\'
SELECT @device_directory = 'D:\database\'


--�������ݿ�
EXECUTE(N'CREATE DATABASE wlserver
	ON PRIMARY (NAME = N''wlserver'', FILENAME = N''' + @device_directory + N'wlserver.mdf'')
	LOG ON (NAME = N''wlserver_log'', FILENAME = N''' + @device_directory + N'wlserver.ldf'')')

--EXECUTE(N'CREATE DATABASE wlserver ON PRIMARY (NAME = N''wlserver'', FILENAME = N''E:\wlserver.mdf'') 
--	LOG ON (NAME = N''wlserver_log'', FILENAME = N''E:\wlserver.ldf'')')
GO

--------------------------------------------------------------------------------------------------
--���ɻ������ݿ�
--------------------------------------------------------------------------------------------------

USE wlserver
GO

--------------------------------------------------------------------------------------------------
--���в�����(����insert��delete��ֻ��select��update)
--xinqia.liu
--2013-05-30
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[SETTING]
CREATE TABLE [dbo].[SETTING](
	[id]			varchar(32)			NOT NULL,						--���(�û�����Զ���)
	[value]			varchar(64)			NOT NULL,

	CONSTRAINT [PK_SETTING] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [SETTING] VALUES ('NodeCode','22010000001')					--�������
INSERT INTO [SETTING] VALUES ('NodeName','�����и��ٿ���վ')			--��������
INSERT INTO [SETTING] VALUES ('CityCode','22010000000')					--���д���
INSERT INTO [SETTING] VALUES ('CityName','����')						--��������
INSERT INTO [SETTING] VALUES ('BillBits','10')							--����ȱʡλ��
INSERT INTO [SETTING] VALUES ('BillZeroize','True')						--�Զ�ǰ�ò����㡯
INSERT INTO [SETTING] VALUES ('SyncCentral','False')					--ͬ���쵥���ݵ����������
INSERT INTO [SETTING] VALUES ('SecurityCheck','True')					--�쵥�Ƿ���밲ȫ���

INSERT INTO [SETTING] VALUES ('HWJSJoinCalc','False')					--��������������
INSERT INTO [SETTING] VALUES ('ManualModify','True')					--�����ֶ��޸��˷�
INSERT INTO [SETTING] VALUES ('SaveCustomer','True')					--�Զ�����ͻ���Ϣ
INSERT INTO [SETTING] VALUES ('OnlyToday','False')						--���ܰ�����ҵ��
INSERT INTO [SETTING] VALUES ('ChargeBZF','True')						--�Ƿ���ȡ��װ��
INSERT INTO [SETTING] VALUES ('AllowDF','False')						--������
INSERT INTO [SETTING] VALUES ('AllowJZ','False')						--�������
INSERT INTO [SETTING] VALUES ('AutoSelectYF','False')					--�Զ�ѡ���˷ѱ�׼
INSERT INTO [SETTING] VALUES ('GDCheckCPH','False')						--�ĵ�ʱ��⳵�ƺ�

INSERT INTO [SETTING] VALUES ('ChargeBXF','True')						--�Ƿ���ȡ���շ�
INSERT INTO [SETTING] VALUES ('BXFAutoCalc','True')						--���շ��Զ�����
INSERT INTO [SETTING] VALUES ('BXFRound','True')						--���շ��Զ�ȡ��
INSERT INTO [SETTING] VALUES ('BXFMin','1')								--��С���շ�
INSERT INTO [SETTING] VALUES ('BXFMax','10')							--����շ�
INSERT INTO [SETTING] VALUES ('BXFRatio','0.001')						--���շѼ������

INSERT INTO [SETTING] VALUES ('JZDay','25')								--������
INSERT INTO [SETTING] VALUES ('JZDefValue','0.50')						--���˴���ȱʡ�������
INSERT INTO [SETTING] VALUES ('CSDefValue','0.50')						--������Ϣȱʡ�������
GO

--------------------------------------------------------------------------------------------------
--��ӡ��ʽ��(����insert��delete��ֻ��select��update)
--xinqia.liu
--2012-06-10
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[PRINT_FORMAT]
CREATE TABLE [dbo].[PRINT_FORMAT](
	[code]			varchar(16)			NOT NULL,						--���
	[name]			varchar(32)			NOT NULL,						--����
	[x]				int					NOT NULL,						--X
	[y]				int					NOT NULL,						--Y
	[font_name]		varchar(32)			NOT NULL,						--��������
	[font_size]		int					NOT NULL,						--�����С
	[font_mode]		varchar(8)			NOT NULL,						--����ģʽ
	[enable]		char(1)				NOT NULL default('Y'),			--�Ƿ��ӡ
	
	[id]			int IDENTITY(1,1)	NOT NULL,						--���

	CONSTRAINT [PK_PRINT_FORMAT] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [PRINT_FORMAT] VALUES ('node','������',0,0,'����',12,'����','N')
INSERT INTO [PRINT_FORMAT] VALUES ('date','����',270,0,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('sn','�˵����',0,0,'����',12,'����','N')
INSERT INTO [PRINT_FORMAT] VALUES ('uid','�û����',0,0,'����',12,'����','N')
INSERT INTO [PRINT_FORMAT] VALUES ('username','�û�����',0,0,'����',12,'����','N')
INSERT INTO [PRINT_FORMAT] VALUES ('cdt','�쵥ʱ��',0,0,'����',12,'����','N')

INSERT INTO [PRINT_FORMAT] VALUES ('sk_type','�׿�����',0,0,'����',12,'����','N')
INSERT INTO [PRINT_FORMAT] VALUES ('yd_type','�˵�����',0,0,'����',12,'����','N')
INSERT INTO [PRINT_FORMAT] VALUES ('zt_type','״̬����',0,0,'����',12,'����','N')

INSERT INTO [PRINT_FORMAT] VALUES ('fh_code','�����������',0,0,'����',12,'����','N')
INSERT INTO [PRINT_FORMAT] VALUES ('fh_name','������������',0,0,'����',12,'����','N')
INSERT INTO [PRINT_FORMAT] VALUES ('fh_cityname','������������',300,30,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('jh_code','�ӻ��������',0,0,'����',12,'����','N')
INSERT INTO [PRINT_FORMAT] VALUES ('jh_name','�ӻ���������',0,0,'����',12,'����','N')

INSERT INTO [PRINT_FORMAT] VALUES ('cz_rq','���ذ೵����',140,90,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('cz_bc','���ذ೵����',140,30,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('cz_dz','���ذ೵�յ�վ',590,30,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('cz_sj','���ذ೵����ʱ��',140,60,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('cz_cph','���ذ೵���ƺ�',140,0,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('cz_lc','���ذ೵���',0,0,'����',12,'����','N')
INSERT INTO [PRINT_FORMAT] VALUES ('cz_yx','���ذ೵����ʱ��',0,0,'����',12,'����','N')

INSERT INTO [PRINT_FORMAT] VALUES ('hw_mc','��������',445,120,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('hw_lx','��������',140,120,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('hw_js','�������',590,120,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('hw_bj','���ﱣ��',140,210,'����',12,'����','Y')

INSERT INTO [PRINT_FORMAT] VALUES ('fhr_name','����������',300,60,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('fhr_mobile','�������ֻ�',445,60,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('fhr_tel','�����˹̻�',550,60,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('fhr_remark','�����˱�ע',445,150,'����',12,'����','Y')

INSERT INTO [PRINT_FORMAT] VALUES ('jhr_name','�ӻ�������',300,90,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('jhr_mobile','�ӻ����ֻ�',445,90,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('jhr_tel','�ӻ��˹̻�',550,90,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('jhr_address','�ӻ��˵�ַ',0,0,'����',12,'����','N')

INSERT INTO [PRINT_FORMAT] VALUES ('bxd_sn','���յ����',0,0,'����',12,'����','N')

INSERT INTO [PRINT_FORMAT] VALUES ('sjzl','ʵ������',300,120,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('jfzl','�Ʒ�����',0,0,'����',12,'����','N')
INSERT INTO [PRINT_FORMAT] VALUES ('jftj','�Ʒ����',0,0,'����',12,'����','N')
INSERT INTO [PRINT_FORMAT] VALUES ('tyf','���˷�',140,150,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('bzf','��װ��',0,0,'����',12,'����','N')
INSERT INTO [PRINT_FORMAT] VALUES ('bxf','���շ�',0,0,'����',12,'����','N')
INSERT INTO [PRINT_FORMAT] VALUES ('total','�ϼƽ��',445,180,'����',12,'����','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('money','ʵ�ս��',0,0,'����',12,'����','N')

INSERT INTO [PRINT_FORMAT] VALUES ('total_upper','��д���',180,240,'����',12,'����','Y')

GO

--------------------------------------------------------------------------------------------------
--�û���
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[USER]
CREATE TABLE [dbo].[USER](
	[userid]		varchar(8)			NOT NULL,						--�û����
	[username]		varchar(32)			NOT NULL,						--�û�����
	[password]		varchar(32)			NOT NULL,						--�û�����
	[nodecode]		varchar(12)			NOT NULL,						--�����������
	[nodename]		varchar(32)			NOT NULL,						--������������			
	[manage_priv]	char(1)				NOT NULL,						--
	[select_priv]	char(1)				NOT NULL,						--
	[insert_priv]	char(1)				NOT NULL,						--
	[update_priv]	char(1)				NOT NULL,						--
	[delete_priv]	char(1)				NOT NULL,						--
	[enable]		char(1)				NOT NULL default('Y'),			--���ñ�־
	[cdt]			datetime			NOT NULL default(getdate()),	--����ʱ��

	CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
	(
		[userid] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO 

--����ɾ��admin�û�
INSERT INTO [USER] VALUES ('admin','����Ա','admin','','','Y', 'Y', 'Y', 'Y', 'Y', 'Y', getdate())
INSERT INTO [USER] VALUES ('101','�װ�01','000000','','','N', 'N', 'N', 'N', 'N', 'Y', getdate())
INSERT INTO [USER] VALUES ('102','�װ�02','000000','','','N', 'N', 'N', 'N', 'N', 'Y', getdate())
INSERT INTO [USER] VALUES ('201','�Ұ�01','000000','','','N', 'N', 'N', 'N', 'N', 'Y', getdate())
INSERT INTO [USER] VALUES ('202','�Ұ�02','000000','','','N', 'N', 'N', 'N', 'N', 'Y', getdate())
GO

--------------------------------------------------------------------------------------------------
--�û�Ʊ�ݱ�
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[BILL]
CREATE TABLE [dbo].[BILL](
	[userid]		varchar(8)			NOT NULL,						--�û����
	[p_start]		int					NOT NULL,						--��ʼƱ��
	[p_count]		int					NOT NULL,						--Ʊ������
	[p_index]		int					NOT NULL,						--ʹ�ü���
	[p_state]		char(1)				NOT NULL,						--Ʊ�ݱ�־(B;S;E)
	[cdt]			datetime			NOT NULL default(getdate()),	--����ʱ��

	CONSTRAINT [PK_BILL] PRIMARY KEY CLUSTERED 
	(
		[userid] ASC, [p_start] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--�������
--ALTER TABLE [dbo].[BILL] ADD CONSTRAINT IX_P_START UNIQUE NONCLUSTERED (p_start) ON [PRIMARY]     
--GO

ALTER TABLE [dbo].[BILL] ADD CONSTRAINT FK_BILL_USER FOREIGN KEY (userid) REFERENCES [USER](userid) 
	ON DELETE CASCADE ON UPDATE CASCADE NOT FOR REPLICATION
GO  

INSERT INTO [BILL] VALUES ('admin', 1, 100, 0, 'B', getdate())
GO

--------------------------------------------------------------------------------------------------
--�ͻ���
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[CUSTOMER]
CREATE TABLE [dbo].[CUSTOMER](
	[name]			varchar(32)			NOT NULL,						--�ͻ�����
	[tel]			varchar(32)			NOT NULL,						--�ͻ��绰
	[address]		varchar(64)			NOT NULL,						--�ͻ���ַ
	[enable]		char(1)				NOT NULL DEFAULT('Y'),			--���ñ�־(Y-����,N-ͣ��)

	CONSTRAINT [PK_CUSTOMER] PRIMARY KEY CLUSTERED 
	(
		[name] ASC, [tel] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--INSERT INTO [CUSTOMER] VALUES ('������', '13500821877', '��¥�����', 'Y')
--INSERT INTO [CUSTOMER] VALUES ('����ǿ', '13756139562', '��¥�����', 'Y')
--GO

--------------------------------------------------------------------------------------------------
--ӳ���
--xinqia.liu
--2013-12-16
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[MAPPING]
CREATE TABLE [dbo].[MAPPING](
	[code]			varchar(16)			NOT NULL,						--����
	[value]			varchar(16)			NOT NULL,						--ӳ��

	CONSTRAINT [PK_MAPPING] PRIMARY KEY CLUSTERED 
	(
		[code] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [MAPPING] VALUES ('JA', '��A')
INSERT INTO [MAPPING] VALUES ('JB', '��B')
INSERT INTO [MAPPING] VALUES ('JC', '��C')
INSERT INTO [MAPPING] VALUES ('JD', '��D')
INSERT INTO [MAPPING] VALUES ('JE', '��E')
INSERT INTO [MAPPING] VALUES ('JF', '��F')
INSERT INTO [MAPPING] VALUES ('JG', '��G')
INSERT INTO [MAPPING] VALUES ('JH', '��H')
GO

--------------------------------------------------------------------------------------------------
--��Ȩ��
--xinqia.liu
--2013-12-16
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[AUTHORIZE]
CREATE TABLE [dbo].[AUTHORIZE](
	[code]			varchar(12)			NOT NULL,						--������
	[name]			varchar(32)			NOT NULL,						--��������
	[citycode]		varchar(12)			NOT NULL,						--������
	[cityname]		varchar(32)			NOT NULL,						--��������
	[content]		varbinary(3000)		NULL,							--����վ���ݿ���Ȩ

	CONSTRAINT [PK_AUTHORIZE] PRIMARY KEY CLUSTERED 
	(
		[code] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO


--------------------------------------------------------------------------------------------------
--�����
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[NODE]
CREATE TABLE [dbo].[NODE](
	[code]			varchar(12)			NOT NULL,						--������
	[name]			varchar(32)			NOT NULL,						--��������
	[citycode]		varchar(12)			NOT NULL,						--���б�ţ�����ʶ��ͬ�ǣ�
	[cityname]		varchar(32)			NOT NULL,						--��������
	[enable]		char(1)				NOT NULL default('N'),			--������־(Y-��ͨ;N-δ��ͨ)
	[address]		varchar(64)			NOT NULL default(''),			--��ַ
	[tel]			varchar(32)			NOT NULL default(''),			--�绰

	CONSTRAINT [PK_NODE] PRIMARY KEY CLUSTERED 
	(
		[code] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('00000000000','δ����','00000000000','��','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000001','�����и��ٿ���վ','22010000000','����','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000002','�����п�������վ','22010000000','����','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000003','�����п�������վ','22010000000','����','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000004','��̨�п�����վ','22010000000','��̨','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000005','ũ���ع�·������վ','22012200000','ũ��','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000006','�����й�·������վ','22018200000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000008','������˫������վ','22012500000','˫��','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000009','�����й�˾����վ','22018200000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000010','�»ݹ�·����վ','22012400000','�»�','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000011','�»ݿ�����վ','22012400000','�»�','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000001','�����й�·������վ','22020000000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000002','�����й�·������վ','22028300000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000003','�����ع�·������վ','22022100000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000004','�Ժ��й�·������վ','22028100000','�Ժ�','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000005','����й�·������վ','22028200000','���','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000007','��ʯ�й�·������վ','22022300000','��ʯ','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000001','��ƽ�й�·������վ','22030000000','��ƽ','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000004','��ƽ���ٹ�·����վ','22030000000','��ƽ','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000002','�����ع�·������վ','22032200000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000003','��ͨ�ع�·������վ','22032300000','��ͨ','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000006','�������п�����վ','22038100000','������','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000007','˫���й�·������վ','22032400000','˫��','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22040000001','��Դ�й�·������վ','22040000000','��Դ','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22040000002','�����ع�·������վ','22042100000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22040000003','�����ع�·������վ','22042200000','����','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000001','ͨ���й�·����վ','22050000000','ͨ��','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000008','ͨ���й�·������վ','22050000000','ͨ��','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000002','÷�ӿ��й�·������վ','22058100000','÷��','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000003','�����ع�·����վ','22052300000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000004','�����й�·����վ','22058200000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000005','ͨ���ع�·����վ','22052100000','ͨ��','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000007','�����ع�·����վ','22052400000','����','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22060000001','��ɽ�й�·������վ','22060000000','��ɽ','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22060000005','��ɽ�й�·������վ','22060000000','��ɽ','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22060000002','�ٽ��ڰ���·������վ','22068100000','�ٽ�','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22060000003','�����ع�·������վ','22062100000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22060000004','�����ع�·������վ','22062200000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22060000006','���������乫˾����վ','22062300000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22060000007','��Դ��·������վ','22060300000','��Դ','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22070000001','��ԭ�й�·������վ','22070000000','��ԭ','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22070000005','��������·������վ','22070000000','��ԭ','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22070000002','�����ع�·����վ','22072200000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22070000003','�����ع�·������վ','22070200000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22070000004','Ǭ���ع�·������վ','22072300000','Ǭ��','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22080000001','�׳������Ŀ���վ','22080000000','�׳�','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22080000002','���й�·������վ','22088200000','��','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22080000003','����й�·������վ','22088100000','���','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22080000004','ͨ���ع�·������վ','22082200000','ͨ��','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22080000005','�����ع�·������վ','22082100000','����','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000001','�Ӽ��й�·������վ','22240100000','�Ӽ�','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000010','�Ӽ��й�·���˱�վ','22240100000','�Ӽ�','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000011','�Ӽ��й�������վ','22240100000','�Ӽ�','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000002','�����й�·������վ','22240200000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000003','�����й�·������վ','22240600000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000004','�����й�·������վ','22240400000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000005','��ͼ�ؿ���վ','22242600000','��ͼ','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000006','�����й�·������վ','22240500000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000007','�ػ��й�·������վ','22240300000','�ػ�','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000008','�ػ��г�;����վ','22240300000','�ػ�','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000009','�����ع�·������վ','22242400000','����','N','','')

GO

--------------------------------------------------------------------------------------------------
--�������ͱ�
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[HWLXB]
CREATE TABLE [dbo].[HWLXB](	
	[name]			varchar(32)			NOT NULL,						--��������
	[id]			int IDENTITY(1,1)	NOT NULL,						--���

	CONSTRAINT [PK_HWLXB] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--ALTER TABLE [dbo].[HWLXB] ADD CONSTRAINT IX_HWLXB_NAME UNIQUE NONCLUSTERED ([name]) ON [PRIMARY]     
--GO

INSERT INTO [HWLXB] VALUES ('��ͨ����')
INSERT INTO [HWLXB] VALUES ('ͨѶ��Ʒ')
INSERT INTO [HWLXB] VALUES ('�ļ�����')
INSERT INTO [HWLXB] VALUES ('��װ')
INSERT INTO [HWLXB] VALUES ('�������')
INSERT INTO [HWLXB] VALUES ('�������')
INSERT INTO [HWLXB] VALUES ('�����Ǳ�')
INSERT INTO [HWLXB] VALUES ('ҩƷ')
INSERT INTO [HWLXB] VALUES ('����')
INSERT INTO [HWLXB] VALUES ('ʳƷ')
INSERT INTO [HWLXB] VALUES ('����Ʒ')
GO

--------------------------------------------------------------------------------------------------
--��ע��Ϣ��
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[BZXXB]
CREATE TABLE [dbo].[BZXXB](	
	[name]			varchar(32)			NOT NULL,						--��ע����
	[id]			int IDENTITY(1,1)	NOT NULL,						--���

	CONSTRAINT [PK_BZXXB] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--ALTER TABLE [dbo].[HWLXB] ADD CONSTRAINT IX_HWLXB_NAME UNIQUE NONCLUSTERED ([name]) ON [PRIMARY]     
--GO

INSERT INTO [BZXXB] VALUES ('')
INSERT INTO [BZXXB] VALUES ('����Ʒ')
INSERT INTO [BZXXB] VALUES ('�����Ը�')
INSERT INTO [BZXXB] VALUES ('���װ������𣨶����Ը�')
INSERT INTO [BZXXB] VALUES ('�Ը���')

--------------------------------------------------------------------------------------------------
--��װ���ʱ�
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[BZFLB]
CREATE TABLE [dbo].[BZFLB](
	[name]			varchar(16)			NOT NULL,						--��װ����
	[value]			decimal(6,2)		NOT NULL,						--��װ����

	[id]			int IDENTITY(1,1)	NOT NULL,						--���

	CONSTRAINT [PK_BZFLB] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [BZFLB] VALUES ('�����װ', 0.00)
INSERT INTO [BZFLB] VALUES ('�ļ���', 2.00)
INSERT INTO [BZFLB] VALUES ('С��װ', 3.00)
INSERT INTO [BZFLB] VALUES ('���װ', 5.00)
GO

--------------------------------------------------------------------------------------------------
--�˷ѱ�
--xinqia.liu
--2013-02-22
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[YFB]
CREATE TABLE [dbo].[YFB](
	[bf]			decimal(6,2)		NOT NULL,						--��۰��ļ���Ԫ��
	[bw]			decimal(6,2)		NOT NULL,						--��۰�������Ԫ��
	[weight]		int					NOT NULL,						--����-����
	[excess]		decimal(6,2)		NOT NULL,						--����/���Ԫ��
	[factor]		decimal(4,2)		NOT NULL,						--�����������ϵ��
	[sm]			int					NOT NULL,						--��ʼ���
	[em]			int					NOT NULL,						--��ֹ���
	[name]			varchar(32)			NOT NULL,						--�˷����ƣ���̣�

	[id]			int IDENTITY(1,1)	NOT NULL,						--���

	CONSTRAINT [PK_YFB] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [YFB] VALUES (15.00, 15.00, 10, 1.00, 0.03, 0, 200, '200��������')
INSERT INTO [YFB] VALUES (20.00, 30.00, 10, 2.00, 0.03, 200, 700, '200��������700��������')
INSERT INTO [YFB] VALUES (30.00, 50.00, 10, 3.00, 0.03, 700, 99999, '700��������')
GO

--------------------------------------------------------------------------------------------------
--�ɿ��¼��
--xinqia.liu
--2013-03-31
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[PAYIN]
CREATE TABLE [dbo].[PAYIN](
	[date]			datetime			NOT NULL,						--�ɿ�����
	[userid]		varchar(8)			NOT NULL,						--�ɿ��û����
	[bds]			int					NOT NULL,						--�쵥��
	[fds]			int					NOT NULL,						--�ϵ���
	[tyf]			decimal(8,2)		NOT NULL,						--���˷�
	[bzf]			decimal(8,2)		NOT NULL,						--��װ��
	[bxf]			decimal(8,2)		NOT NULL,						--���շ�
	[total]			decimal(8,2)		NOT NULL,						--�ϼƽ��
	[money]			decimal(8,2)		NOT NULL,						--�ɿ���
	[count]			int					NOT NULL,						--�ɿ����
	[uid]			varchar(8)			NOT NULL,						--�����û����
	[cdt]			datetime			NOT NULL default(getdate()),	--���ɿ�ʱ��
		
	CONSTRAINT [PK_PAYIN] PRIMARY KEY CLUSTERED 
	(
		[date] ASC, [userid] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--�ϵ���
--xinqia.liu
--2012-06-23
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[FDB]
CREATE TABLE [dbo].[FDB](	
	[node]			varchar(12)			NOT NULL,						--����
	[date]			datetime			NOT NULL,						--����
	[sn]			varchar(12)			NOT NULL,						--����
	[uid]			varchar(8)			NOT NULL,						--�û����
	[cdt]			datetime			NOT NULL default(getdate()),	--����ʱ��

	[id]			int IDENTITY(1,1)	NOT NULL,						--���
	CONSTRAINT [PK_FDB] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--�ĵ���
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[GDB]
CREATE TABLE [dbo].[GDB](
	[node]			varchar(12)			NOT NULL,						--����
	[date]			datetime			NOT NULL,						--����
	[sn]			varchar(12)			NOT NULL,						--����
	[old_cph]		varchar(8)			NOT NULL,						--ԭ���ذ೵���ƺ�	
	[old_rq]		datetime			NOT NULL,						--ԭ���ذ೵����
	[old_bc]		varchar(8)			NOT NULL,						--ԭ���ذ೵����
	[new_cph]		varchar(8)			NOT NULL,						--�³��ذ೵���ƺ�
	[new_rq]		datetime			NOT NULL,						--�³��ذ೵����
	[new_bc]		varchar(8)			NOT NULL,						--�³��ذ೵����
	[record_type]	char(1)				NOT NULL default('M'),			--��¼���� M �ֹ��ĵ� S ͬ���ĵ�
	[uid]			varchar(8)			NOT NULL,						--�û����
	[cdt]			datetime			NOT NULL default(getdate()),	--����ʱ��

	[id]			int IDENTITY(1,1)	NOT NULL,						--���
	CONSTRAINT [PK_GDB] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--��ǰ������
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[WLB]
CREATE TABLE [dbo].[WLB](
	[node]			varchar(12)			NOT NULL,						--��������
	[date]			datetime			NOT NULL,						--����
	[sn]			varchar(12)			NOT NULL,						--Ʊ��	
	[uid]			varchar(8)			NOT NULL,						--�û����
	[cdt]			datetime			NOT NULL default(getdate()),	--����ʱ��	
	--������Ϣ
	[sk_type]		char(1)				NOT NULL,						--�տ�����(X�ֽ�;D����;A����)
	[yd_type]		char(1)				NOT NULL,						--�˵�����(S����;F�ϵ�;R���;Cͬ�ǻ��ܽ���)
	[zt_type]		char(1)				NOT NULL,						--״̬����(J�ӻ�;Zװ��;Xж��;Sȡ��;E�¹�)
	--������Ϣ
	[fh_code]		varchar(11)			NOT NULL,						--�����������
	[fh_name]		varchar(32)			NOT NULL,						--������������
	[fh_cityname]	varchar(32)			NOT NULL,						--������������
	[jh_code]		varchar(11)			NOT NULL,						--�ӻ��������
	[jh_name]		varchar(32)			NOT NULL,						--�ӻ���������
	--������Ϣ
	[cz_rq]			datetime			NOT NULL,						--���ذ೵����
	[cz_bc]			varchar(8)			NOT NULL,						--���ذ೵����
	[cz_dz]			varchar(8)			NOT NULL,						--���ذ೵�յ�վ
	[cz_sj]			char(5)				NOT NULL,						--���ذ೵����ʱ��
	[cz_cph]		varchar(8)			NOT NULL,						--���ذ೵���ƺ�
	[cz_lc]			int					NOT NULL,						--���ذ೵���
	[cz_yx]			char(5)				NOT NULL,						--���ذ೵����ʱ��
	--������Ϣ
	[hw_mc]			varchar(32)			NOT NULL,						--��������
	[hw_lx]			varchar(32)			NOT NULL,						--��������
	[hw_js]			int					NOT NULL,						--�������
	[hw_bj]			decimal(8,2)		NOT NULL,						--���ﱣ��	
	--��������Ϣ
	[fhr_name]		varchar(32)			NOT NULL,						--����������
	[fhr_mobile]	varchar(32)			NOT NULL,						--�������ֻ�
	[fhr_remark]	varchar(64)			NOT NULL,						--�����˱�ע(�ɱ���೵��Ʊ��)
	--�ӻ�����Ϣ
	[jhr_name]		varchar(32)			NOT NULL,						--�ӻ�������
	[jhr_mobile]	varchar(32)			NOT NULL,						--�ӻ����ֻ�
	--������Ϣ
	[jfzl]			decimal(8,2)		NOT NULL,						--�Ʒ�����
	[jftj]			decimal(8,2)		NOT NULL,						--�Ʒ����
	[tyf]			decimal(8,2)		NOT NULL,						--���˷�
	[bzf]			decimal(8,2)		NOT NULL,						--��װ��
	[bxf]			decimal(8,2)		NOT NULL,						--���շ�
	[total]			decimal(8,2)		NOT NULL,						--�ϼƽ��
	[money]			decimal(8,2)		NOT NULL,						--ʵ�ս��

	[bxd_sn]		varchar(32)			NOT NULL,						--���յ����

	[freeze]		char(1)				NOT NULL default('N'),			--�Ƿ񶳽ᣨ�����ս��ΪY��
	[synced]		char(1)				NOT NULL default('N'),			--�Ƿ�ͬ����ͬ�����ĺ�ΪY��
	
	[sets]			char(32)			NOT NULL,						--���ü�

	CONSTRAINT [PK_WLB] PRIMARY KEY CLUSTERED 
	(
		[node] ASC, [date] ASC, [sn] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--�ս��
--xinqia.liu
--2013-06-10
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[EndOfDay]
CREATE TABLE [dbo].[EndOfDay](
	[date]			datetime			NOT NULL,						--����	
	[uid]			varchar(8)			NOT NULL,						--�����û����
	[cdt]			datetime			NOT NULL default(getdate()),	--ʱ��

	[id]			int IDENTITY(1,1)	NOT NULL,						--���
	CONSTRAINT [PK_EndOfDay] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--���˴����
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[CSXXB]
--DROP TABLE [dbo].[JZDMB]
CREATE TABLE [dbo].[JZDMB](
	[code]			varchar(8)			NOT NULL,						--���˴���
	[name]			varchar(32)			NOT NULL,						--��λ����
	[value]			decimal(4,2)		NOT NULL,						--���˱���
	[mode]			int					NOT NULL,						--����ģʽ[0ͳһ,1����]
	[address]		varchar(64)			NOT NULL,						--��λ��ַ
	[tel]			varchar(32)			NOT NULL,						--��λ�绰

	CONSTRAINT [PK_JZDMB] PRIMARY KEY CLUSTERED 
	(
		[code] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--INSERT INTO [JZDMB] VALUES ('0000','�޹�������',0,'','')
--GO

--------------------------------------------------------------------------------------------------
--������Ϣ��
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
CREATE TABLE [dbo].[CSXXB](
	[cph]			varchar(8)			NOT NULL,						--���ƺ�
	[name]			varchar(32)			NOT NULL,						--��������
	[code]			varchar(8)			NOT NULL,						--���˴���
	[value]			decimal(4,2)		NOT NULL,						--���˱���
	[address]		varchar(64)			NOT NULL,						--������ַ
	[tel]			varchar(32)			NOT NULL,						--�����绰
	
	CONSTRAINT [PK_CSXXB] PRIMARY KEY CLUSTERED 
	(
		[cph] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CSXXB] ADD CONSTRAINT FK_CSXXB_JZDMB FOREIGN KEY (code) REFERENCES JZDMB(code) 
	ON UPDATE CASCADE NOT FOR REPLICATION
GO

--ȡ������ɾ������ֹ����ʱ����ɾ���������������Ľ��˴���
--ON DELETE CASCADE ON UPDATE CASCADE NOT FOR REPLICATION
--GO

--------------------------------------------------------------------------------------------------
--�˵���
--xinqia.liu
--2013-03-23
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[ZDB]
CREATE TABLE [dbo].[ZDB](	
	[year]			int					NOT NULL,						--���
	[month]			int					NOT NULL,						--�·�
	[name]			varchar(32)			NOT NULL,						--�˵�����
	[sdt]			datetime			NOT NULL,						--��ʼ����
	[edt]			datetime			NOT NULL,						--��ֹ����
	[uid]			varchar(8)			NOT NULL,						--�����û�
	[cdt]			datetime			NOT NULL default(getdate()),	--����ʱ��

	CONSTRAINT [PK_ZDB] PRIMARY KEY CLUSTERED 
	(
		[year] ASC, [month] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO


--------------------------------------------------------------------------------------------------
--�˵����ܱ�
--xinqia.liu
--2013-03-23
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[ZDHZB]
CREATE TABLE [dbo].[ZDHZB](
	[year]			int					NOT NULL,						--���
	[month]			int					NOT NULL,						--�·�	
	[code]			varchar(8)			NOT NULL,						--���˴���	
	[cars]			int					NOT NULL,						--��������
	[count]			int					NOT NULL,						--�˵�����
	[total]			decimal(8,2)		NOT NULL,						--�˵��ܶ�
	[money]			decimal(8,2)		NOT NULL,						--���˽��
	[uid]			varchar(8)			NOT NULL,						--�����û�
	[cdt]			datetime			NOT NULL default(getdate()),	--����ʱ��	

	CONSTRAINT [PK_ZDHZB] PRIMARY KEY CLUSTERED 
	(
		[year] ASC, [month] ASC, [code] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--ALTER TABLE [dbo].[ZDHZB] ADD CONSTRAINT FK_ZDHZB_ZDB FOREIGN KEY (year,month) REFERENCES ZDB(year,month)
--	ON DELETE CASCADE ON UPDATE CASCADE NOT FOR REPLICATION
--GO 

--------------------------------------------------------------------------------------------------
--�˵���ϸ��
--xinqia.liu
--2013-03-23
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[ZDMXB]
CREATE TABLE [dbo].[ZDMXB](
	[year]			int					NOT NULL,						--���
	[month]			int					NOT NULL,						--�·�
	[code]			varchar(8)			NOT NULL,						--���˴���	
	[cph]			varchar(8)			NOT NULL,						--���ƺ�
	[count]			int					NOT NULL,						--�����˵���
	[total]			decimal(8,2)		NOT NULL,						--�����˵���
	[ratio]			decimal(4,2)		NOT NULL,						--�������
	[money]			decimal(8,2)		NOT NULL,						--�������˽��

	CONSTRAINT [PK_ZDMXB] PRIMARY KEY CLUSTERED 
	(
		[year] ASC, [month] ASC, [code] ASC, [cph] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--ALTER TABLE [dbo].[ZDMXB] ADD CONSTRAINT FK_ZDMXB_ZDHZB FOREIGN KEY (year,month,code) REFERENCES ZDHZB(year,month,code)
--	ON DELETE CASCADE ON UPDATE CASCADE NOT FOR REPLICATION
--GO 

--------------------------------------------------------------------------------------------------
--�ձ���
--xinqia.liu
--2013-06-06
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[DailySheet]
CREATE TABLE [dbo].[DailySheet](
	[date]			datetime			NOT NULL,						--����
	[nodecode]		varchar(12)			NOT NULL,						--�������
	[nodename]		varchar(32)			NOT NULL,						--��������
	[counts1]		int					NOT NULL,						--���յ���
	[packages1]		int					NOT NULL,						--���ռ���	 
	[total1]		decimal(8,2)		NOT NULL,						--���ս��
	[counts2]		int					NOT NULL,						--Ԥ�쵥��
	[packages2]		int					NOT NULL,						--Ԥ�����
	[total2]		decimal(8,2)		NOT NULL,						--Ԥ����		
	[counts]		int					NOT NULL,						--�ϼƵ���
	[packages]		int					NOT NULL,						--�ϼƼ���
	[total]			decimal(8,2)		NOT NULL,						--�ϼƽ��
	
	[uid]			varchar(8)			NOT NULL,						--�����û����
	[cdt]			datetime			NOT NULL default(getdate()),	--ʱ��
	CONSTRAINT [PK_DailySheet] PRIMARY KEY CLUSTERED 
	(
		[date] ASC, [nodecode] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO
