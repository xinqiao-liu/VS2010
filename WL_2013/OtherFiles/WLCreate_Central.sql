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
IF EXISTS(SELECT * FROM sysdatabases WHERE name='wlserver_central')
	DROP DATABASE wlserver_central
GO

--���������ݿ��ļ��洢Ŀ¼
--DECLARE @device_directory NVARCHAR(520)
--SELECT @device_directory = SUBSTRING(filename, 1 ,CHARINDEX(N'master.mdf', LOWER(filename)) - 1)
--	FROM master.dbo.sysaltfiles WHERE dbid = 1 AND fileid = 1

--�������ݿ�
--EXECUTE(N'CREATE DATABASE wlserver_central
--	ON PRIMARY (NAME = N''wlserver_central'', FILENAME = N''' + @device_directory + N'wlserver_central.mdf'')
--	LOG ON (NAME = N''wlserver_central_log'', FILENAME = N''' + @device_directory + N'wlserver_central.ldf'')')

EXECUTE(N'CREATE DATABASE wlserver_central ON PRIMARY (NAME = N''wlserver_central'', FILENAME = N''E:\wlserver_central.mdf'') 
	LOG ON (NAME = N''wlserver_central_log'', FILENAME = N''E:\wlserver_central.ldf'')')
GO

--------------------------------------------------------------------------------------------------
--�����������ݿ�
--------------------------------------------------------------------------------------------------

USE wlserver_central
GO

--------------------------------------------------------------------------------------------------
--���в�����(����insert��delete��ֻ��select��update)
--xinqia.liu
--2013-05-30
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[SETTING]
CREATE TABLE [dbo].[SETTING](
	[id]			varchar(32)			NOT NULL,						--���(��������Զ���)
	[value]			varchar(64)			NOT NULL,

	CONSTRAINT [PK_SETTING] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [SETTING] VALUES ('SyncVersion','2014-1-12')				--ͬ���汾
--����������ͬ��������������ݣ���������Ϣ���˷ѱ�׼�������������ͬ���汾�������������ͬ��ͬ��
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
GO

--------------------------------------------------------------------------------------------------
--��������ڸ���������ͬ����
--xinqia.liu
--2013-12-16
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

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000001','�����й�·������վ','22020000000','����','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000002','�����й�·������վ','22028300000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000003','�����ع�·������վ','22022100000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000004','�Ժ��й�·������վ','22028100000','�Ժ�','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000005','����й�·������վ','22028200000','���','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000007','��ʯ�й�·������վ','22022300000','��ʯ','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000001','��ƽ�й�·������վ','22030000000','��ƽ','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000004','��ƽ���ٹ�·����վ','22030000000','��ƽ','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000002','�����ع�·������վ','22032200000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000003','��ͨ�ع�·������վ','22032300000','��ͨ','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000006','�������п�����վ','22038100000','������','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000007','˫���й�·������վ','22032400000','˫��','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22040000001','��Դ�й�·������վ','22040000000','��Դ','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22040000002','�����ع�·������վ','22042100000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22040000003','�����ع�·������վ','22042200000','����','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000001','ͨ���й�·����վ','22050000000','ͨ��','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000008','ͨ���й�·������վ','22050000000','ͨ��','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000002','÷�ӿ��й�·������վ','22058100000','÷��','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000003','�����ع�·����վ','22052300000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000004','�����й�·����վ','22058200000','����','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000005','ͨ���ع�·����վ','22052100000','ͨ��','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000007','�����ع�·����վ','22052400000','����','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22060000001','��ɽ�й�·������վ','22060000000','��ɽ','Y','','')
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

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22080000001','�׳������Ŀ���վ','22080000000','�׳�','Y','','')
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
--��ע��Ϣ��
--xinqia.liu
--2013-12-25
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
INSERT INTO [BZXXB] VALUES ('�ͻ�����')
INSERT INTO [BZXXB] VALUES ('�ͻ�����')

--------------------------------------------------------------------------------------------------
--�˷ѱ����ڸ���������ͬ����
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
--����������������ѯ��
--xinqia.liu
--2013-06-06
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
	[yd_type]		char(1)				NOT NULL,						--�˵�����(S����;F�ϵ�;R�ⵥ)
	[zt_type]		char(1)				NOT NULL,						--״̬����(J�ӻ�;Zװ��;Xж��;S�ջ�;E�¹�)
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
	[synced]		char(1)				NOT NULL default('Y'),			--�Ƿ�ͬ����ͬ�����ĺ�ΪY��

	[sets]			char(32)			NOT NULL,						--���ü�

	CONSTRAINT [PK_WLB] PRIMARY KEY CLUSTERED 
	(
		[node] ASC, [date] ASC, [sn] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--���ٱ�
--xinqia.liu
--2013-12-16
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[WLT]
CREATE TABLE [dbo].[WLT](	
	[node]			varchar(12)			NOT NULL,						--����
	[date]			datetime			NOT NULL,						--����	
	[sn]			varchar(12)			NOT NULL,						--Ʊ��	
	[content]		varchar(256)		NOT NULL,						--����
	[cdt]			datetime			NOT NULL default(getdate()),	--ʱ��

	[id]			int IDENTITY(1,1)	NOT NULL,						--���
	CONSTRAINT [PK_WLT] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO


