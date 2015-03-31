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
IF EXISTS(SELECT * FROM sysdatabases WHERE name='wlserver_central')
	DROP DATABASE wlserver_central
GO

--返回主数据库文件存储目录
--DECLARE @device_directory NVARCHAR(520)
--SELECT @device_directory = SUBSTRING(filename, 1 ,CHARINDEX(N'master.mdf', LOWER(filename)) - 1)
--	FROM master.dbo.sysaltfiles WHERE dbid = 1 AND fileid = 1

--创建数据库
--EXECUTE(N'CREATE DATABASE wlserver_central
--	ON PRIMARY (NAME = N''wlserver_central'', FILENAME = N''' + @device_directory + N'wlserver_central.mdf'')
--	LOG ON (NAME = N''wlserver_central_log'', FILENAME = N''' + @device_directory + N'wlserver_central.ldf'')')

EXECUTE(N'CREATE DATABASE wlserver_central ON PRIMARY (NAME = N''wlserver_central'', FILENAME = N''E:\wlserver_central.mdf'') 
	LOG ON (NAME = N''wlserver_central_log'', FILENAME = N''E:\wlserver_central.ldf'')')
GO

--------------------------------------------------------------------------------------------------
--生成中央数据库
--------------------------------------------------------------------------------------------------

USE wlserver_central
GO

--------------------------------------------------------------------------------------------------
--运行参数表(不能insert、delete，只能select、update)
--xinqia.liu
--2013-05-30
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[SETTING]
CREATE TABLE [dbo].[SETTING](
	[id]			varchar(32)			NOT NULL,						--编号(参数编号自定义)
	[value]			varchar(64)			NOT NULL,

	CONSTRAINT [PK_SETTING] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [SETTING] VALUES ('SyncVersion','2014-1-12')				--同步版本
--用于子网点同步中央服务器数据（如网点信息、运费标准），如果子网点同步版本与中央服务器不同则同步
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
GO

--------------------------------------------------------------------------------------------------
--网点表（用于给各子网点同步）
--xinqia.liu
--2013-12-16
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

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000001','吉林市公路客运总站','22020000000','吉林','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000002','舒兰市公路客运总站','22028300000','舒兰','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000003','永吉县公路客运总站','22022100000','永吉','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000004','蛟河市公路客运总站','22028100000','蛟河','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000005','桦甸市公路客运总站','22028200000','桦甸','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22020000007','磐石市公路客运总站','22022300000','磐石','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000001','四平市公路客运总站','22030000000','四平','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000004','四平高速公路客运站','22030000000','四平','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000002','梨树县公路客运总站','22032200000','梨树','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000003','伊通县公路客运总站','22032300000','伊通','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000006','公主岭市客运总站','22038100000','公主岭','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22030000007','双辽市公路客运总站','22032400000','双辽','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22040000001','辽源市公路客运总站','22040000000','辽源','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22040000002','东丰县公路客运总站','22042100000','东丰','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22040000003','东辽县公路客运总站','22042200000','东辽','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000001','通化市公路客运站','22050000000','通化','Y','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000008','通化市公路客运新站','22050000000','通化','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000002','梅河口市公路客运总站','22058100000','梅河','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000003','辉南县公路客运站','22052300000','辉南','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000004','集安市公路客运站','22058200000','集安','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000005','通化县公路客运站','22052100000','通化','N','','')
INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22050000007','柳河县公路客运站','22052400000','柳河','N','','')

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22060000001','白山市公路客运总站','22060000000','白山','Y','','')
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

INSERT INTO [NODE] ([code], [name], [citycode], [cityname], [enable], [address], [tel]) VALUES ('22080000001','白城市中心客运站','22080000000','白城','Y','','')
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
--备注信息表
--xinqia.liu
--2013-12-25
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
INSERT INTO [BZXXB] VALUES ('客户自提')
INSERT INTO [BZXXB] VALUES ('送货上门')

--------------------------------------------------------------------------------------------------
--运费表（用于给各子网点同步）
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
--中心物流表（联网查询）
--xinqia.liu
--2013-06-06
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
	[yd_type]		char(1)				NOT NULL,						--运单类型(S常规;F废单;R外单)
	[zt_type]		char(1)				NOT NULL,						--状态类型(J接货;Z装车;X卸车;S收货;E事故)
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
	[synced]		char(1)				NOT NULL default('Y'),			--是否同步（同步中心后为Y）

	[sets]			char(32)			NOT NULL,						--配置集

	CONSTRAINT [PK_WLB] PRIMARY KEY CLUSTERED 
	(
		[node] ASC, [date] ASC, [sn] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO

--------------------------------------------------------------------------------------------------
--跟踪表
--xinqia.liu
--2013-12-16
--------------------------------------------------------------------------------------------------
--DROP TABLE [dbo].[WLT]
CREATE TABLE [dbo].[WLT](	
	[node]			varchar(12)			NOT NULL,						--网点
	[date]			datetime			NOT NULL,						--日期	
	[sn]			varchar(12)			NOT NULL,						--票号	
	[content]		varchar(256)		NOT NULL,						--内容
	[cdt]			datetime			NOT NULL default(getdate()),	--时间

	[id]			int IDENTITY(1,1)	NOT NULL,						--编号
	CONSTRAINT [PK_WLT] PRIMARY KEY CLUSTERED 
	(
		[id] ASC
	) ON [PRIMARY]
) ON [PRIMARY]
GO


