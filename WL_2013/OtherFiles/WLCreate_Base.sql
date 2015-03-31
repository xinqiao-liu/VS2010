--------------------------------------------------------------------------------------------------
--公路客运联网物流系统（节点数据库）
--
--版本：2013.06.5
--

--------------------------------------------------------------------------------------------------
--生成数据库
--------------------------------------------------------------------------------------------------

SET NOCOUNT ON
GO

USE master
GO

--检测数据库是否存在，如果存在则删除
IF EXISTS(SELECT * FROM sysdatabases WHERE name='wlserver')
	DROP DATABASE wlserver
GO

--返回主数据库文件存储目录
DECLARE @device_directory NVARCHAR(520)
--SELECT @device_directory = 'D:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\'
SELECT @device_directory = 'D:\database\'


--创建数据库
EXECUTE(N'CREATE DATABASE wlserver
	ON PRIMARY (NAME = N''wlserver'', FILENAME = N''' + @device_directory + N'wlserver.mdf'')
	LOG ON (NAME = N''wlserver_log'', FILENAME = N''' + @device_directory + N'wlserver.ldf'')')

--EXECUTE(N'CREATE DATABASE wlserver ON PRIMARY (NAME = N''wlserver'', FILENAME = N''E:\wlserver.mdf'') 
--	LOG ON (NAME = N''wlserver_log'', FILENAME = N''E:\wlserver.ldf'')')
GO

--------------------------------------------------------------------------------------------------
--生成基础数据库
--------------------------------------------------------------------------------------------------

USE wlserver
GO

--------------------------------------------------------------------------------------------------
--运行参数表(不能insert、delete，只能select、update)
--xinqia.liu
--2013-05-30
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[SETTING]
CREATE TABLE [dbo].[SETTING](
	[id]			varchar(32)			NOT NULL,						--编号(用户编号自定义)
	[value]			varchar(64)			NOT NULL,

	CONSTRAINT [PK_SETTING] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [SETTING] VALUES ('NodeCode','22010000001')					--网点代码
INSERT INTO [SETTING] VALUES ('NodeName','长春市高速客运站')			--网点名称
INSERT INTO [SETTING] VALUES ('CityCode','22010000000')					--城市代码
INSERT INTO [SETTING] VALUES ('CityName','长春')						--城市名称
INSERT INTO [SETTING] VALUES ('BillBits','10')							--单据缺省位数
INSERT INTO [SETTING] VALUES ('BillZeroize','True')						--自动前置补‘零’
INSERT INTO [SETTING] VALUES ('SyncCentral','False')					--同步办单数据到中央服务器
INSERT INTO [SETTING] VALUES ('SecurityCheck','True')					--办单是否必须安全检查

INSERT INTO [SETTING] VALUES ('HWJSJoinCalc','False')					--货物件数参与计算
INSERT INTO [SETTING] VALUES ('ManualModify','True')					--允许手动修改运费
INSERT INTO [SETTING] VALUES ('SaveCustomer','True')					--自动保存客户信息
INSERT INTO [SETTING] VALUES ('OnlyToday','False')						--仅能办理当日业务
INSERT INTO [SETTING] VALUES ('ChargeBZF','True')						--是否收取包装费
INSERT INTO [SETTING] VALUES ('AllowDF','False')						--允许到付
INSERT INTO [SETTING] VALUES ('AllowJZ','False')						--允许记账
INSERT INTO [SETTING] VALUES ('AutoSelectYF','False')					--自动选择运费标准
INSERT INTO [SETTING] VALUES ('GDCheckCPH','False')						--改单时检测车牌号

INSERT INTO [SETTING] VALUES ('ChargeBXF','True')						--是否收取保险费
INSERT INTO [SETTING] VALUES ('BXFAutoCalc','True')						--保险费自动计算
INSERT INTO [SETTING] VALUES ('BXFRound','True')						--保险费自动取整
INSERT INTO [SETTING] VALUES ('BXFMin','1')								--最小保险费
INSERT INTO [SETTING] VALUES ('BXFMax','10')							--最大保险费
INSERT INTO [SETTING] VALUES ('BXFRatio','0.001')						--保险费计算比率

INSERT INTO [SETTING] VALUES ('JZDay','25')								--结帐日
INSERT INTO [SETTING] VALUES ('JZDefValue','0.50')						--结账代码缺省结算比例
INSERT INTO [SETTING] VALUES ('CSDefValue','0.50')						--车属信息缺省结算比例
GO

--------------------------------------------------------------------------------------------------
--打印格式表(不能insert、delete，只能select、update)
--xinqia.liu
--2012-06-10
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[PRINT_FORMAT]
CREATE TABLE [dbo].[PRINT_FORMAT](
	[code]			varchar(16)			NOT NULL,						--编号
	[name]			varchar(32)			NOT NULL,						--名称
	[x]				int					NOT NULL,						--X
	[y]				int					NOT NULL,						--Y
	[font_name]		varchar(32)			NOT NULL,						--字体名称
	[font_size]		int					NOT NULL,						--字体大小
	[font_mode]		varchar(8)			NOT NULL,						--字体模式
	[enable]		char(1)				NOT NULL default('Y'),			--是否打印
	
	[id]			int IDENTITY(1,1)	NOT NULL,						--编号

	CONSTRAINT [PK_PRINT_FORMAT] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [PRINT_FORMAT] VALUES ('node','网点编号',0,0,'宋体',12,'常规','N')
INSERT INTO [PRINT_FORMAT] VALUES ('date','日期',270,0,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('sn','运单编号',0,0,'宋体',12,'常规','N')
INSERT INTO [PRINT_FORMAT] VALUES ('uid','用户编号',0,0,'宋体',12,'常规','N')
INSERT INTO [PRINT_FORMAT] VALUES ('username','用户名称',0,0,'宋体',12,'常规','N')
INSERT INTO [PRINT_FORMAT] VALUES ('cdt','办单时间',0,0,'宋体',12,'常规','N')

INSERT INTO [PRINT_FORMAT] VALUES ('sk_type','首款类型',0,0,'宋体',12,'常规','N')
INSERT INTO [PRINT_FORMAT] VALUES ('yd_type','运单类型',0,0,'宋体',12,'常规','N')
INSERT INTO [PRINT_FORMAT] VALUES ('zt_type','状态类型',0,0,'宋体',12,'常规','N')

INSERT INTO [PRINT_FORMAT] VALUES ('fh_code','发货网点代码',0,0,'宋体',12,'常规','N')
INSERT INTO [PRINT_FORMAT] VALUES ('fh_name','发货网点名称',0,0,'宋体',12,'常规','N')
INSERT INTO [PRINT_FORMAT] VALUES ('fh_cityname','发货城市名称',300,30,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('jh_code','接货网点代码',0,0,'宋体',12,'常规','N')
INSERT INTO [PRINT_FORMAT] VALUES ('jh_name','接货网点名称',0,0,'宋体',12,'常规','N')

INSERT INTO [PRINT_FORMAT] VALUES ('cz_rq','承载班车日期',140,90,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('cz_bc','承载班车车次',140,30,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('cz_dz','承载班车终到站',590,30,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('cz_sj','承载班车发车时间',140,60,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('cz_cph','承载班车车牌号',140,0,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('cz_lc','承载班车里程',0,0,'宋体',12,'常规','N')
INSERT INTO [PRINT_FORMAT] VALUES ('cz_yx','承载班车运行时间',0,0,'宋体',12,'常规','N')

INSERT INTO [PRINT_FORMAT] VALUES ('hw_mc','货物名称',445,120,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('hw_lx','货物类型',140,120,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('hw_js','货物件数',590,120,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('hw_bj','货物保金',140,210,'宋体',12,'常规','Y')

INSERT INTO [PRINT_FORMAT] VALUES ('fhr_name','发货人名称',300,60,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('fhr_mobile','发货人手机',445,60,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('fhr_tel','发货人固话',550,60,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('fhr_remark','发货人备注',445,150,'宋体',12,'常规','Y')

INSERT INTO [PRINT_FORMAT] VALUES ('jhr_name','接货人名称',300,90,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('jhr_mobile','接货人手机',445,90,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('jhr_tel','接货人固话',550,90,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('jhr_address','接货人地址',0,0,'宋体',12,'常规','N')

INSERT INTO [PRINT_FORMAT] VALUES ('bxd_sn','保险单编号',0,0,'宋体',12,'常规','N')

INSERT INTO [PRINT_FORMAT] VALUES ('sjzl','实际重量',300,120,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('jfzl','计费重量',0,0,'宋体',12,'常规','N')
INSERT INTO [PRINT_FORMAT] VALUES ('jftj','计费体积',0,0,'宋体',12,'常规','N')
INSERT INTO [PRINT_FORMAT] VALUES ('tyf','托运费',140,150,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('bzf','包装费',0,0,'宋体',12,'常规','N')
INSERT INTO [PRINT_FORMAT] VALUES ('bxf','保险费',0,0,'宋体',12,'常规','N')
INSERT INTO [PRINT_FORMAT] VALUES ('total','合计金额',445,180,'宋体',12,'常规','Y')
INSERT INTO [PRINT_FORMAT] VALUES ('money','实收金额',0,0,'宋体',12,'常规','N')

INSERT INTO [PRINT_FORMAT] VALUES ('total_upper','大写金额',180,240,'宋体',12,'常规','Y')

GO

--------------------------------------------------------------------------------------------------
--用户表
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[USER]
CREATE TABLE [dbo].[USER](
	[userid]		varchar(8)			NOT NULL,						--用户编号
	[username]		varchar(32)			NOT NULL,						--用户名称
	[password]		varchar(32)			NOT NULL,						--用户密码
	[nodecode]		varchar(12)			NOT NULL,						--隶属网点代码
	[nodename]		varchar(32)			NOT NULL,						--隶属网点名称			
	[manage_priv]	char(1)				NOT NULL,						--
	[select_priv]	char(1)				NOT NULL,						--
	[insert_priv]	char(1)				NOT NULL,						--
	[update_priv]	char(1)				NOT NULL,						--
	[delete_priv]	char(1)				NOT NULL,						--
	[enable]		char(1)				NOT NULL default('Y'),			--启用标志
	[cdt]			datetime			NOT NULL default(getdate()),	--创建时间

	CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
	(
		[userid] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO 

--不能删除admin用户
INSERT INTO [USER] VALUES ('admin','管理员','admin','','','Y', 'Y', 'Y', 'Y', 'Y', 'Y', getdate())
INSERT INTO [USER] VALUES ('101','甲班01','000000','','','N', 'N', 'N', 'N', 'N', 'Y', getdate())
INSERT INTO [USER] VALUES ('102','甲班02','000000','','','N', 'N', 'N', 'N', 'N', 'Y', getdate())
INSERT INTO [USER] VALUES ('201','乙班01','000000','','','N', 'N', 'N', 'N', 'N', 'Y', getdate())
INSERT INTO [USER] VALUES ('202','乙班02','000000','','','N', 'N', 'N', 'N', 'N', 'Y', getdate())
GO

--------------------------------------------------------------------------------------------------
--用户票据表
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[BILL]
CREATE TABLE [dbo].[BILL](
	[userid]		varchar(8)			NOT NULL,						--用户编号
	[p_start]		int					NOT NULL,						--起始票号
	[p_count]		int					NOT NULL,						--票据总数
	[p_index]		int					NOT NULL,						--使用计数
	[p_state]		char(1)				NOT NULL,						--票据标志(B;S;E)
	[cdt]			datetime			NOT NULL default(getdate()),	--创建时间

	CONSTRAINT [PK_BILL] PRIMARY KEY CLUSTERED 
	(
		[userid] ASC, [p_start] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--添加索引
--ALTER TABLE [dbo].[BILL] ADD CONSTRAINT IX_P_START UNIQUE NONCLUSTERED (p_start) ON [PRIMARY]     
--GO

ALTER TABLE [dbo].[BILL] ADD CONSTRAINT FK_BILL_USER FOREIGN KEY (userid) REFERENCES [USER](userid) 
	ON DELETE CASCADE ON UPDATE CASCADE NOT FOR REPLICATION
GO  

INSERT INTO [BILL] VALUES ('admin', 1, 100, 0, 'B', getdate())
GO

--------------------------------------------------------------------------------------------------
--客户表
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[CUSTOMER]
CREATE TABLE [dbo].[CUSTOMER](
	[name]			varchar(32)			NOT NULL,						--客户名称
	[tel]			varchar(32)			NOT NULL,						--客户电话
	[address]		varchar(64)			NOT NULL,						--客户地址
	[enable]		char(1)				NOT NULL DEFAULT('Y'),			--启用标志(Y-启用,N-停用)

	CONSTRAINT [PK_CUSTOMER] PRIMARY KEY CLUSTERED 
	(
		[name] ASC, [tel] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--INSERT INTO [CUSTOMER] VALUES ('刘新桥', '13500821877', '四楼监控室', 'Y')
--INSERT INTO [CUSTOMER] VALUES ('刘新强', '13756139562', '四楼监控室', 'Y')
--GO

--------------------------------------------------------------------------------------------------
--映射表
--xinqia.liu
--2013-12-16
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[MAPPING]
CREATE TABLE [dbo].[MAPPING](
	[code]			varchar(16)			NOT NULL,						--代码
	[value]			varchar(16)			NOT NULL,						--映射

	CONSTRAINT [PK_MAPPING] PRIMARY KEY CLUSTERED 
	(
		[code] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [MAPPING] VALUES ('JA', '吉A')
INSERT INTO [MAPPING] VALUES ('JB', '吉B')
INSERT INTO [MAPPING] VALUES ('JC', '吉C')
INSERT INTO [MAPPING] VALUES ('JD', '吉D')
INSERT INTO [MAPPING] VALUES ('JE', '吉E')
INSERT INTO [MAPPING] VALUES ('JF', '吉F')
INSERT INTO [MAPPING] VALUES ('JG', '吉G')
INSERT INTO [MAPPING] VALUES ('JH', '吉H')
GO

--------------------------------------------------------------------------------------------------
--授权表
--xinqia.liu
--2013-12-16
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[AUTHORIZE]
CREATE TABLE [dbo].[AUTHORIZE](
	[code]			varchar(12)			NOT NULL,						--网点编号
	[name]			varchar(32)			NOT NULL,						--网点名称
	[citycode]		varchar(12)			NOT NULL,						--网点编号
	[cityname]		varchar(32)			NOT NULL,						--网点名称
	[content]		varbinary(3000)		NULL,							--客运站数据库授权

	CONSTRAINT [PK_AUTHORIZE] PRIMARY KEY CLUSTERED 
	(
		[code] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO


--------------------------------------------------------------------------------------------------
--网点表
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[NODE]
CREATE TABLE [dbo].[NODE](
	[code]			varchar(12)			NOT NULL,						--网点编号
	[name]			varchar(32)			NOT NULL,						--网点名称
	[citycode]		varchar(12)			NOT NULL,						--城市编号（用于识别同城）
	[cityname]		varchar(32)			NOT NULL,						--城市名称
	[enable]		char(1)				NOT NULL default('N'),			--联网标志(Y-开通;N-未开通)
	[address]		varchar(64)			NOT NULL default(''),			--地址
	[tel]			varchar(32)			NOT NULL default(''),			--电话

	CONSTRAINT [PK_NODE] PRIMARY KEY CLUSTERED 
	(
		[code] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('00000000000','未联网','00000000000','无','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000001','长春市高速客运站','22010000000','长春','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000002','长春市凯旋客运站','22010000000','长春','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000003','长春市客运中心站','22010000000','长春','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000004','九台市客运总站','22010000000','九台','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000005','农安县公路客运总站','22012200000','农安','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000006','榆树市公路客运总站','22018200000','榆树','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000008','长春市双阳客运站','22012500000','双阳','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000009','榆树市公司客运站','22018200000','榆树','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000010','德惠公路客运站','22012400000','德惠','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22010000011','德惠客运总站','22012400000','德惠','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000001','吉林市公路客运总站','22020000000','吉林','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000002','舒兰市公路客运总站','22028300000','舒兰','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000003','永吉县公路客运总站','22022100000','永吉','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000004','蛟河市公路客运总站','22028100000','蛟河','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000005','桦甸市公路客运总站','22028200000','桦甸','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000007','磐石市公路客运总站','22022300000','磐石','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000001','四平市公路客运总站','22030000000','四平','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000004','四平高速公路客运站','22030000000','四平','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000002','梨树县公路客运总站','22032200000','梨树','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000003','伊通县公路客运总站','22032300000','伊通','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000006','公主岭市客运总站','22038100000','公主岭','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000007','双辽市公路客运总站','22032400000','双辽','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22040000001','辽源市公路客运总站','22040000000','辽源','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22040000002','东丰县公路客运总站','22042100000','东丰','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22040000003','东辽县公路客运总站','22042200000','东辽','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000001','通化市公路客运站','22050000000','通化','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000008','通化市公路客运新站','22050000000','通化','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000002','梅河口市公路客运总站','22058100000','梅河','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000003','辉南县公路客运站','22052300000','辉南','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000004','集安市公路客运站','22058200000','集安','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000005','通化县公路客运站','22052100000','通化','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000007','柳河县公路客运站','22052400000','柳河','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22060000001','白山市公路客运总站','22060000000','白山','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22060000005','白山市公路西客运站','22060000000','白山','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22060000002','临江口岸公路客运总站','22068100000','临江','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22060000003','抚松县公路客运总站','22062100000','抚松','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22060000004','靖宇县公路客运总站','22062200000','靖宇','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22060000006','长白县运输公司客运站','22062300000','长白','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22060000007','江源公路客运总站','22060300000','江源','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22070000001','松原市公路客运总站','22070000000','松原','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22070000005','宁江区公路客运总站','22070000000','松原','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22070000002','长岭县公路客运站','22072200000','长岭','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22070000003','扶余县公路客运总站','22070200000','扶余','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22070000004','乾安县公路客运总站','22072300000','乾安','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22080000001','白城市中心客运站','22080000000','白城','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22080000002','大安市公路客运总站','22088200000','大安','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22080000003','洮南市公路客运总站','22088100000','洮南','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22080000004','通榆县公路客运总站','22082200000','通榆','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22080000005','镇赉县公路客运总站','22082100000','镇赉','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000001','延吉市公路客运总站','22240100000','延吉','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000010','延吉市公路客运北站','22240100000','延吉','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000011','延吉市公铁分流站','22240100000','延吉','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000002','和龙市公路客运总站','22240200000','和龙','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000003','和龙市公路客运总站','22240600000','和龙','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000004','珲春市公路客运总站','22240400000','珲春','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000005','安图县客运站','22242600000','安图','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000006','龙井市公路客运总站','22240500000','龙井','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000007','敦化市公路客运总站','22240300000','敦化','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000008','敦化市长途客运站','22240300000','敦化','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22240000009','汪清县公路客运总站','22242400000','汪清','N','','')

GO

--------------------------------------------------------------------------------------------------
--货物类型表
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[HWLXB]
CREATE TABLE [dbo].[HWLXB](	
	[name]			varchar(32)			NOT NULL,						--类型名称
	[id]			int IDENTITY(1,1)	NOT NULL,						--编号

	CONSTRAINT [PK_HWLXB] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--ALTER TABLE [dbo].[HWLXB] ADD CONSTRAINT IX_HWLXB_NAME UNIQUE NONCLUSTERED ([name]) ON [PRIMARY]     
--GO

INSERT INTO [HWLXB] VALUES ('普通货物')
INSERT INTO [HWLXB] VALUES ('通讯产品')
INSERT INTO [HWLXB] VALUES ('文件资料')
INSERT INTO [HWLXB] VALUES ('服装')
INSERT INTO [HWLXB] VALUES ('电脑配件')
INSERT INTO [HWLXB] VALUES ('汽车配件')
INSERT INTO [HWLXB] VALUES ('仪器仪表')
INSERT INTO [HWLXB] VALUES ('药品')
INSERT INTO [HWLXB] VALUES ('海鲜')
INSERT INTO [HWLXB] VALUES ('食品')
INSERT INTO [HWLXB] VALUES ('日用品')
GO

--------------------------------------------------------------------------------------------------
--备注信息表
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[BZXXB]
CREATE TABLE [dbo].[BZXXB](	
	[name]			varchar(32)			NOT NULL,						--备注名称
	[id]			int IDENTITY(1,1)	NOT NULL,						--编号

	CONSTRAINT [PK_BZXXB] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--ALTER TABLE [dbo].[HWLXB] ADD CONSTRAINT IX_HWLXB_NAME UNIQUE NONCLUSTERED ([name]) ON [PRIMARY]     
--GO

INSERT INTO [BZXXB] VALUES ('')
INSERT INTO [BZXXB] VALUES ('易碎品')
INSERT INTO [BZXXB] VALUES ('死亡自负')
INSERT INTO [BZXXB] VALUES ('外包装完好内损（冻损）自负')
INSERT INTO [BZXXB] VALUES ('对付款')

--------------------------------------------------------------------------------------------------
--包装费率表
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[BZFLB]
CREATE TABLE [dbo].[BZFLB](
	[name]			varchar(16)			NOT NULL,						--包装类型
	[value]			decimal(6,2)		NOT NULL,						--包装费率

	[id]			int IDENTITY(1,1)	NOT NULL,						--编号

	CONSTRAINT [PK_BZFLB] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [BZFLB] VALUES ('自理包装', 0.00)
INSERT INTO [BZFLB] VALUES ('文件袋', 2.00)
INSERT INTO [BZFLB] VALUES ('小包装', 3.00)
INSERT INTO [BZFLB] VALUES ('大包装', 5.00)
GO

--------------------------------------------------------------------------------------------------
--运费表
--xinqia.liu
--2013-02-22
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[YFB]
CREATE TABLE [dbo].[YFB](
	[bf]			decimal(6,2)		NOT NULL,						--起价按文件（元）
	[bw]			decimal(6,2)		NOT NULL,						--起价按重量（元）
	[weight]		int					NOT NULL,						--起重-公斤
	[excess]		decimal(6,2)		NOT NULL,						--续费/公斤（元）
	[factor]		decimal(4,2)		NOT NULL,						--体积折算重量系数
	[sm]			int					NOT NULL,						--起始里程
	[em]			int					NOT NULL,						--截止里程
	[name]			varchar(32)			NOT NULL,						--运费名称（里程）

	[id]			int IDENTITY(1,1)	NOT NULL,						--编号

	CONSTRAINT [PK_YFB] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [YFB] VALUES (15.00, 15.00, 10, 1.00, 0.03, 0, 200, '200公里以下')
INSERT INTO [YFB] VALUES (20.00, 30.00, 10, 2.00, 0.03, 200, 700, '200公里以上700公里以下')
INSERT INTO [YFB] VALUES (30.00, 50.00, 10, 3.00, 0.03, 700, 99999, '700公里以上')
GO

--------------------------------------------------------------------------------------------------
--缴款记录表
--xinqia.liu
--2013-03-31
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[PAYIN]
CREATE TABLE [dbo].[PAYIN](
	[date]			datetime			NOT NULL,						--缴款日期
	[userid]		varchar(8)			NOT NULL,						--缴款用户编号
	[bds]			int					NOT NULL,						--办单数
	[fds]			int					NOT NULL,						--废单数
	[tyf]			decimal(8,2)		NOT NULL,						--托运费
	[bzf]			decimal(8,2)		NOT NULL,						--包装费
	[bxf]			decimal(8,2)		NOT NULL,						--保险费
	[total]			decimal(8,2)		NOT NULL,						--合计金额
	[money]			decimal(8,2)		NOT NULL,						--缴款金额
	[count]			int					NOT NULL,						--缴款次数
	[uid]			varchar(8)			NOT NULL,						--操作用户编号
	[cdt]			datetime			NOT NULL default(getdate()),	--最后缴款时间
		
	CONSTRAINT [PK_PAYIN] PRIMARY KEY CLUSTERED 
	(
		[date] ASC, [userid] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--废单表
--xinqia.liu
--2012-06-23
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[FDB]
CREATE TABLE [dbo].[FDB](	
	[node]			varchar(12)			NOT NULL,						--网点
	[date]			datetime			NOT NULL,						--日期
	[sn]			varchar(12)			NOT NULL,						--单号
	[uid]			varchar(8)			NOT NULL,						--用户编号
	[cdt]			datetime			NOT NULL default(getdate()),	--操作时间

	[id]			int IDENTITY(1,1)	NOT NULL,						--编号
	CONSTRAINT [PK_FDB] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--改单表
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[GDB]
CREATE TABLE [dbo].[GDB](
	[node]			varchar(12)			NOT NULL,						--网点
	[date]			datetime			NOT NULL,						--日期
	[sn]			varchar(12)			NOT NULL,						--单号
	[old_cph]		varchar(8)			NOT NULL,						--原承载班车车牌号	
	[old_rq]		datetime			NOT NULL,						--原承载班车日期
	[old_bc]		varchar(8)			NOT NULL,						--原承载班车车次
	[new_cph]		varchar(8)			NOT NULL,						--新承载班车车牌号
	[new_rq]		datetime			NOT NULL,						--新承载班车日期
	[new_bc]		varchar(8)			NOT NULL,						--新承载班车车次
	[record_type]	char(1)				NOT NULL default('M'),			--记录类型 M 手工改单 S 同步改单
	[uid]			varchar(8)			NOT NULL,						--用户编号
	[cdt]			datetime			NOT NULL default(getdate()),	--操作时间

	[id]			int IDENTITY(1,1)	NOT NULL,						--编号
	CONSTRAINT [PK_GDB] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--当前物流表
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[WLB]
CREATE TABLE [dbo].[WLB](
	[node]			varchar(12)			NOT NULL,						--本地网点
	[date]			datetime			NOT NULL,						--日期
	[sn]			varchar(12)			NOT NULL,						--票号	
	[uid]			varchar(8)			NOT NULL,						--用户编号
	[cdt]			datetime			NOT NULL default(getdate()),	--操作时间	
	--属性信息
	[sk_type]		char(1)				NOT NULL,						--收款类型(X现金;D到付;A记账)
	[yd_type]		char(1)				NOT NULL,						--运单类型(S常规;F废单;R异地;C同城汇总结账)
	[zt_type]		char(1)				NOT NULL,						--状态类型(J接货;Z装车;X卸车;S取货;E事故)
	--网点信息
	[fh_code]		varchar(11)			NOT NULL,						--发货网点编码
	[fh_name]		varchar(32)			NOT NULL,						--发货网点名称
	[fh_cityname]	varchar(32)			NOT NULL,						--发货城市名称
	[jh_code]		varchar(11)			NOT NULL,						--接货网点编码
	[jh_name]		varchar(32)			NOT NULL,						--接货网点名称
	--承载信息
	[cz_rq]			datetime			NOT NULL,						--承载班车日期
	[cz_bc]			varchar(8)			NOT NULL,						--承载班车车次
	[cz_dz]			varchar(8)			NOT NULL,						--承载班车终到站
	[cz_sj]			char(5)				NOT NULL,						--承载班车发车时间
	[cz_cph]		varchar(8)			NOT NULL,						--承载班车车牌号
	[cz_lc]			int					NOT NULL,						--承载班车里程
	[cz_yx]			char(5)				NOT NULL,						--承载班车运行时间
	--货物信息
	[hw_mc]			varchar(32)			NOT NULL,						--货物类型
	[hw_lx]			varchar(32)			NOT NULL,						--货物名称
	[hw_js]			int					NOT NULL,						--货物件数
	[hw_bj]			decimal(8,2)		NOT NULL,						--货物保金	
	--发货人信息
	[fhr_name]		varchar(32)			NOT NULL,						--发货人姓名
	[fhr_mobile]	varchar(32)			NOT NULL,						--发货人手机
	[fhr_remark]	varchar(64)			NOT NULL,						--发货人备注(可保存班车客票号)
	--接货人信息
	[jhr_name]		varchar(32)			NOT NULL,						--接货人姓名
	[jhr_mobile]	varchar(32)			NOT NULL,						--接货人手机
	--费用信息
	[jfzl]			decimal(8,2)		NOT NULL,						--计费重量
	[jftj]			decimal(8,2)		NOT NULL,						--计费体积
	[tyf]			decimal(8,2)		NOT NULL,						--托运费
	[bzf]			decimal(8,2)		NOT NULL,						--包装费
	[bxf]			decimal(8,2)		NOT NULL,						--保险费
	[total]			decimal(8,2)		NOT NULL,						--合计金费
	[money]			decimal(8,2)		NOT NULL,						--实收金费

	[bxd_sn]		varchar(32)			NOT NULL,						--保险单编号

	[freeze]		char(1)				NOT NULL default('N'),			--是否冻结（办理日结后为Y）
	[synced]		char(1)				NOT NULL default('N'),			--是否同步（同步中心后为Y）
	
	[sets]			char(32)			NOT NULL,						--配置集

	CONSTRAINT [PK_WLB] PRIMARY KEY CLUSTERED 
	(
		[node] ASC, [date] ASC, [sn] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--日结表
--xinqia.liu
--2013-06-10
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[EndOfDay]
CREATE TABLE [dbo].[EndOfDay](
	[date]			datetime			NOT NULL,						--日期	
	[uid]			varchar(8)			NOT NULL,						--操作用户编号
	[cdt]			datetime			NOT NULL default(getdate()),	--时间

	[id]			int IDENTITY(1,1)	NOT NULL,						--编号
	CONSTRAINT [PK_EndOfDay] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--结账代码表
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[CSXXB]
--DROP TABLE [dbo].[JZDMB]
CREATE TABLE [dbo].[JZDMB](
	[code]			varchar(8)			NOT NULL,						--结账代码
	[name]			varchar(32)			NOT NULL,						--单位名称
	[value]			decimal(4,2)		NOT NULL,						--结账比率
	[mode]			int					NOT NULL,						--结账模式[0统一,1独立]
	[address]		varchar(64)			NOT NULL,						--单位地址
	[tel]			varchar(32)			NOT NULL,						--单位电话

	CONSTRAINT [PK_JZDMB] PRIMARY KEY CLUSTERED 
	(
		[code] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--INSERT INTO [JZDMB] VALUES ('0000','无归属车辆',0,'','')
--GO

--------------------------------------------------------------------------------------------------
--车属信息表
--xinqia.liu
--2012-06-09
--------------------------------------------------------------------------------------------------
CREATE TABLE [dbo].[CSXXB](
	[cph]			varchar(8)			NOT NULL,						--车牌号
	[name]			varchar(32)			NOT NULL,						--车主名称
	[code]			varchar(8)			NOT NULL,						--结账代码
	[value]			decimal(4,2)		NOT NULL,						--结账比率
	[address]		varchar(64)			NOT NULL,						--车主地址
	[tel]			varchar(32)			NOT NULL,						--车主电话
	
	CONSTRAINT [PK_CSXXB] PRIMARY KEY CLUSTERED 
	(
		[cph] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CSXXB] ADD CONSTRAINT FK_CSXXB_JZDMB FOREIGN KEY (code) REFERENCES JZDMB(code) 
	ON UPDATE CASCADE NOT FOR REPLICATION
GO

--取消连级删除，防止操作时意外删除存在隶属车辆的结账代码
--ON DELETE CASCADE ON UPDATE CASCADE NOT FOR REPLICATION
--GO

--------------------------------------------------------------------------------------------------
--账单表
--xinqia.liu
--2013-03-23
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[ZDB]
CREATE TABLE [dbo].[ZDB](	
	[year]			int					NOT NULL,						--年度
	[month]			int					NOT NULL,						--月份
	[name]			varchar(32)			NOT NULL,						--账单名称
	[sdt]			datetime			NOT NULL,						--起始日期
	[edt]			datetime			NOT NULL,						--截止日期
	[uid]			varchar(8)			NOT NULL,						--创建用户
	[cdt]			datetime			NOT NULL default(getdate()),	--创建时间

	CONSTRAINT [PK_ZDB] PRIMARY KEY CLUSTERED 
	(
		[year] ASC, [month] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO


--------------------------------------------------------------------------------------------------
--账单汇总表
--xinqia.liu
--2013-03-23
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[ZDHZB]
CREATE TABLE [dbo].[ZDHZB](
	[year]			int					NOT NULL,						--年度
	[month]			int					NOT NULL,						--月份	
	[code]			varchar(8)			NOT NULL,						--结账代码	
	[cars]			int					NOT NULL,						--车辆总数
	[count]			int					NOT NULL,						--运单总数
	[total]			decimal(8,2)		NOT NULL,						--运单总额
	[money]			decimal(8,2)		NOT NULL,						--结账金额
	[uid]			varchar(8)			NOT NULL,						--结账用户
	[cdt]			datetime			NOT NULL default(getdate()),	--结账时间	

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
--账单明细表
--xinqia.liu
--2013-03-23
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[ZDMXB]
CREATE TABLE [dbo].[ZDMXB](
	[year]			int					NOT NULL,						--年度
	[month]			int					NOT NULL,						--月份
	[code]			varchar(8)			NOT NULL,						--结账代码	
	[cph]			varchar(8)			NOT NULL,						--车牌号
	[count]			int					NOT NULL,						--车辆运单数
	[total]			decimal(8,2)		NOT NULL,						--车辆运单额
	[ratio]			decimal(4,2)		NOT NULL,						--结算比率
	[money]			decimal(8,2)		NOT NULL,						--车辆结账金额

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
--日报表
--xinqia.liu
--2013-06-06
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[DailySheet]
CREATE TABLE [dbo].[DailySheet](
	[date]			datetime			NOT NULL,						--日期
	[nodecode]		varchar(12)			NOT NULL,						--网点代码
	[nodename]		varchar(32)			NOT NULL,						--网点名称
	[counts1]		int					NOT NULL,						--当日单数
	[packages1]		int					NOT NULL,						--当日件数	 
	[total1]		decimal(8,2)		NOT NULL,						--当日金额
	[counts2]		int					NOT NULL,						--预办单数
	[packages2]		int					NOT NULL,						--预办件数
	[total2]		decimal(8,2)		NOT NULL,						--预办金额		
	[counts]		int					NOT NULL,						--合计单数
	[packages]		int					NOT NULL,						--合计件数
	[total]			decimal(8,2)		NOT NULL,						--合计金额
	
	[uid]			varchar(8)			NOT NULL,						--操作用户编号
	[cdt]			datetime			NOT NULL default(getdate()),	--时间
	CONSTRAINT [PK_DailySheet] PRIMARY KEY CLUSTERED 
	(
		[date] ASC, [nodecode] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO
