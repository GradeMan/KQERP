if exists (select * from sysobjects where id = OBJECT_ID('[tb_C001_Company]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_C001_Company]

CREATE TABLE [tb_C001_Company] (
[Id] [uniqueidentifier]  NOT NULL,
[Name] [nvarchar]  (50) NULL,
[Alias] [nvarchar]  (50) NULL,
[Add1] [nvarchar]  (100) NULL,
[Add2] [nvarchar]  (100) NULL,
[Add3] [nvarchar]  (100) NULL,
[Tel] [nvarchar]  (50) NULL,
[Fax] [nvarchar]  (50) NULL,
[Email] [nvarchar]  (50) NULL,
[Version] [timestamp]  NULL,
[CreateDt] [datetime]  NULL,
[CreateUser] [nvarchar]  (50) NULL,
[ModifyDt] [datetime]  NULL,
[ModifyUser] [nvarchar]  (50) NULL)

ALTER TABLE [tb_C001_Company] WITH NOCHECK ADD  CONSTRAINT [PK_tb_C001_Company] PRIMARY KEY  NONCLUSTERED ( [Id] )
INSERT [tb_C001_Company] ([Id],[Name],[Alias],[Add1],[Add3],[Version]) VALUES ( N'8bb2d366-d0ac-4aff-a6a4-656ef61fd503',N'点点滴滴',N'多大的',N'但是得到的的',N'的',System.Byte[])
INSERT [tb_C001_Company] ([Id],[Name],[Alias],[Add1],[Version],[CreateDt],[CreateUser],[ModifyDt],[ModifyUser]) VALUES ( N'6f34adeb-a880-4d82-931c-d68ae647ee3d',N'KQTest',N'KQ',N'22222',System.Byte[],N'2014/12/28 0:28:50',N'admin',N'2014/12/28 0:29:11',N'admin')
if exists (select * from sysobjects where id = OBJECT_ID('[tb_C005_Employee]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_C005_Employee]

CREATE TABLE [tb_C005_Employee] (
[Id] [uniqueidentifier]  NOT NULL,
[CompCode] [nvarchar]  (50) NULL,
[EmpNo] [nvarchar]  (50) NULL,
[Name] [nvarchar]  (50) NULL,
[BirthDate] [datetime]  NULL,
[City] [nvarchar]  (50) NULL,
[Add1] [nvarchar]  (100) NULL,
[Add2] [nvarchar]  (100) NULL,
[ZIPCode] [nchar]  (10) NULL,
[TelPhone] [nvarchar]  (50) NULL,
[Phone] [nvarchar]  (50) NULL,
[Email] [nvarchar]  (50) NULL,
[DeptCode] [nvarchar]  (50) NULL,
[JobCode] [nvarchar]  (50) NULL,
[WrokDt] [datetime]  NULL,
[Photo] [image]  NULL,
[Status] [nvarchar]  (50) NULL,
[Remarks] [nvarchar]  (50) NULL,
[Version] [timestamp]  NULL,
[CreateDt] [datetime]  NULL,
[CreateUser] [nvarchar]  (50) NULL,
[ModifyDt] [datetime]  NULL,
[ModifyUser] [nvarchar]  (50) NULL)

ALTER TABLE [tb_C005_Employee] WITH NOCHECK ADD  CONSTRAINT [PK_tb_C005_Employee] PRIMARY KEY  NONCLUSTERED ( [Id] )
INSERT [tb_C005_Employee] ([Id],[CompCode],[EmpNo],[Name],[BirthDate],[City],[ZIPCode],[WrokDt],[Photo],[Version],[CreateDt],[ModifyDt],[ModifyUser]) VALUES ( N'04e9d4ba-4579-442f-baaa-d7fb2f062028',N'K10',N'p0001',N'zhangsan',N'2014/12/3 0:00:00',N'gdd',N'ddd',N'2014/12/10 0:00:00',System.Byte[],System.Byte[],N'2014/12/2 0:00:00',N'2014/12/28 0:29:33',N'admin')
if exists (select * from sysobjects where id = OBJECT_ID('[tb_Sys_Button]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_Sys_Button]

CREATE TABLE [tb_Sys_Button] (
[Id] [uniqueidentifier]  NOT NULL,
[Btn_Name] [nvarchar]  (50) NULL,
[Btn_Icon] [image]  NULL,
[Btn_SeqNo] [nvarchar]  (50) NULL,
[Version] [timestamp]  NULL,
[CreateTime] [datetime]  NULL,
[ModifyTime] [datetime]  NULL,
[CreateUser] [nvarchar]  (20) NULL,
[ModifyUser] [nvarchar]  (20) NULL)

ALTER TABLE [tb_Sys_Button] WITH NOCHECK ADD  CONSTRAINT [PK_tb_Sys_Button] PRIMARY KEY  NONCLUSTERED ( [Id] )
INSERT [tb_Sys_Button] ([Id],[Btn_Name],[Btn_Icon],[Btn_SeqNo],[Version]) VALUES ( N'5fbdd22f-a938-47a2-946f-1d79b76ba960',N'新增',System.Byte[],N'1',System.Byte[])
INSERT [tb_Sys_Button] ([Id],[Btn_Name],[Btn_Icon],[Btn_SeqNo],[Version]) VALUES ( N'205607e5-e93d-4226-8dae-e8c6b8e8927c',N'删除',System.Byte[],N'3',System.Byte[])
INSERT [tb_Sys_Button] ([Id],[Btn_Name],[Btn_Icon],[Btn_SeqNo],[Version]) VALUES ( N'7f870b14-7373-490b-9a9c-ed9520d05ea7',N'修改',System.Byte[],N'2',System.Byte[])
if exists (select * from sysobjects where id = OBJECT_ID('[tb_Sys_Logs]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_Sys_Logs]

CREATE TABLE [tb_Sys_Logs] (
[Id] [int]  IDENTITY (1, 1)  NOT NULL,
[Date] [datetime]  NULL,
[Thread] [nvarchar]  (255) NULL,
[Log_level] [nvarchar]  (50) NULL,
[Logger] [nvarchar]  (255) NULL,
[Message] [nvarchar]  (2000) NULL,
[Exception] [nvarchar]  (2000) NULL)

ALTER TABLE [tb_Sys_Logs] WITH NOCHECK ADD  CONSTRAINT [PK_tb_Sys_Logs] PRIMARY KEY  NONCLUSTERED ( [Id] )
SET IDENTITY_INSERT [tb_Sys_Logs] ON

INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 1,N'2014/12/22 13:26:34',N'1',N'WARN',N'ERP.Winform.Service.LogServive',N'字段错误',N'Util.AppException: 字段错误
   在 ERP.Winform.Form1.button5_Click(Object sender, EventArgs e) 位置 E:\winform\KQProject\ERPClient\ERP.Winform\Form1.cs:行号 58
   在 System.Windows.Forms.Control.OnClick(EventArgs e)
   在 System.Windows.Forms.Button.OnClick(EventArgs e)
   在 System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 System.Windows.Forms.ButtonBase.WndProc(Message& m)
   在 System.Windows.Forms.Button.WndProc(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 2,N'2014/12/22 13:28:59',N'1',N'WARN',N'ERP.Winform.Service.LogServive',N'字段错误',N'Util.AppException: 字段错误
   在 ERP.Winform.Form1.button5_Click(Object sender, EventArgs e) 位置 E:\winform\KQProject\ERPClient\ERP.Winform\Form1.cs:行号 58
   在 System.Windows.Forms.Control.OnClick(EventArgs e)
   在 System.Windows.Forms.Button.OnClick(EventArgs e)
   在 System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 System.Windows.Forms.ButtonBase.WndProc(Message& m)
   在 System.Windows.Forms.Button.WndProc(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 3,N'2014/12/22 17:51:16',N'1',N'WARN',N'ERP.Winform.Service.LogServive',N'姓名不能为空',N'Util.AppException: 姓名不能为空
   在 Util.ValidationHandler.Handle(ValidationResultCollection results) 位置 E:\winform\KQProject\Utils\Util\Validations\ValidationHandler.cs:行号 21
   在 COM.Domain.DomainBase.HandlerValidationResult(ValidationResultCollection results) 位置 E:\winform\KQProject\Utils\COM.Net\COM.Domain\Entity\DomainBase.cs:行号 115
   在 COM.Domain.DomainBase.Validate() 位置 E:\winform\KQProject\Utils\COM.Net\COM.Domain\Entity\DomainBase.cs:行号 105
   在 ERP.Service.tb_Sys_UserService.Createtb_Sys_User(tb_Sys_User tb_Sys_User) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\tb_Sys_User.cs:行号 41
   在 ERP.Winform.Form1.button1_Click(Object sender, EventArgs e) 位置 E:\winform\KQProject\ERPClient\ERP.Winform\Form1.cs:行号 31
   在 System.Windows.Forms.Control.OnClick(EventArgs e)
   在 System.Windows.Forms.Button.OnClick(EventArgs e)
   在 System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 System.Windows.Forms.ButtonBase.WndProc(Message& m)
   在 System.Windows.Forms.Button.WndProc(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 4,N'2014/12/22 17:51:21',N'1',N'WARN',N'ERP.Winform.Service.LogServive',N'姓名不能为空',N'Util.AppException: 姓名不能为空
   在 Util.ValidationHandler.Handle(ValidationResultCollection results) 位置 E:\winform\KQProject\Utils\Util\Validations\ValidationHandler.cs:行号 21
   在 COM.Domain.DomainBase.HandlerValidationResult(ValidationResultCollection results) 位置 E:\winform\KQProject\Utils\COM.Net\COM.Domain\Entity\DomainBase.cs:行号 115
   在 COM.Domain.DomainBase.Validate() 位置 E:\winform\KQProject\Utils\COM.Net\COM.Domain\Entity\DomainBase.cs:行号 105
   在 ERP.Service.tb_Sys_UserService.Createtb_Sys_User(tb_Sys_User tb_Sys_User) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\tb_Sys_User.cs:行号 41
   在 ERP.Winform.Form1.button1_Click(Object sender, EventArgs e) 位置 E:\winform\KQProject\ERPClient\ERP.Winform\Form1.cs:行号 31
   在 System.Windows.Forms.Control.OnClick(EventArgs e)
   在 System.Windows.Forms.Button.OnClick(EventArgs e)
   在 System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 System.Windows.Forms.ButtonBase.WndProc(Message& m)
   在 System.Windows.Forms.Button.WndProc(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 5,N'2014/12/22 17:52:04',N'1',N'WARN',N'ERP.Winform.Service.LogServive',N'姓名不能为空',N'Util.AppException: 姓名不能为空
   在 Util.ValidationHandler.Handle(ValidationResultCollection results) 位置 E:\winform\KQProject\Utils\Util\Validations\ValidationHandler.cs:行号 21
   在 COM.Domain.DomainBase.HandlerValidationResult(ValidationResultCollection results) 位置 E:\winform\KQProject\Utils\COM.Net\COM.Domain\Entity\DomainBase.cs:行号 115
   在 COM.Domain.DomainBase.Validate() 位置 E:\winform\KQProject\Utils\COM.Net\COM.Domain\Entity\DomainBase.cs:行号 105
   在 ERP.Service.tb_Sys_UserService.Createtb_Sys_User(tb_Sys_User tb_Sys_User) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\tb_Sys_User.cs:行号 41
   在 ERP.Winform.Form1.button1_Click(Object sender, EventArgs e) 位置 E:\winform\KQProject\ERPClient\ERP.Winform\Form1.cs:行号 31
   在 System.Windows.Forms.Control.OnClick(EventArgs e)
   在 System.Windows.Forms.Button.OnClick(EventArgs e)
   在 System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 System.Windows.Forms.ButtonBase.WndProc(Message& m)
   在 System.Windows.Forms.Button.WndProc(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 6,N'2014/12/22 17:52:38',N'1',N'WARN',N'ERP.Winform.Service.LogServive',N'密码不能为空',N'Util.AppException: 密码不能为空
   在 Util.ValidationHandler.Handle(ValidationResultCollection results) 位置 E:\winform\KQProject\Utils\Util\Validations\ValidationHandler.cs:行号 21
   在 COM.Domain.DomainBase.HandlerValidationResult(ValidationResultCollection results) 位置 E:\winform\KQProject\Utils\COM.Net\COM.Domain\Entity\DomainBase.cs:行号 115
   在 COM.Domain.DomainBase.Validate() 位置 E:\winform\KQProject\Utils\COM.Net\COM.Domain\Entity\DomainBase.cs:行号 105
   在 ERP.Service.tb_Sys_UserService.Createtb_Sys_User(tb_Sys_User tb_Sys_User) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\tb_Sys_User.cs:行号 41
   在 ERP.Winform.Form1.button1_Click(Object sender, EventArgs e) 位置 E:\winform\KQProject\ERPClient\ERP.Winform\Form1.cs:行号 32
   在 System.Windows.Forms.Control.OnClick(EventArgs e)
   在 System.Windows.Forms.Button.OnClick(EventArgs e)
   在 System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 System.Windows.Forms.ButtonBase.WndProc(Message& m)
   在 System.Windows.Forms.Button.WndProc(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 7,N'2014/12/23 15:31:26',N'1',N'WARN',N'ERP.Winform.Service.LogServive',N'用户名不存在',N'Util.AppException: 用户名不存在
   在 ERP.Service.tb_Sys_UserService.CheckUserPassword(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\tb_Sys_User.cs:行号 93
   在 ERP.Service.AppLoginService.LoginAsERPUser(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\AppLoginService.cs:行号 34
   在 ERP.Winform.SysModule.LoginForm.btnLogin_Click(Object sender, EventArgs e) 位置 E:\winform\KQProject\ERPClient\ERP.Winform\SysModule\LoginForm.cs:行号 119
   在 System.Windows.Forms.Control.OnClick(EventArgs e)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 8,N'2014/12/23 15:31:37',N'1',N'WARN',N'ERP.Winform.Service.LogServive',N'用户名不存在',N'Util.AppException: 用户名不存在
   在 ERP.Service.tb_Sys_UserService.CheckUserPassword(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\tb_Sys_User.cs:行号 93
   在 ERP.Service.AppLoginService.LoginAsERPUser(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\AppLoginService.cs:行号 34
   在 ERP.Winform.SysModule.LoginForm.btnLogin_Click(Object sender, EventArgs e) 位置 E:\winform\KQProject\ERPClient\ERP.Winform\SysModule\LoginForm.cs:行号 119
   在 System.Windows.Forms.Control.OnClick(EventArgs e)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 9,N'2014/12/23 15:32:50',N'1',N'WARN',N'ERP.Winform.Service.LogServive',N'用户名或密码错误',N'Util.AppException: 用户名或密码错误
   在 ERP.Service.tb_Sys_UserService.CheckUserPassword(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\tb_Sys_User.cs:行号 95
   在 ERP.Service.AppLoginService.LoginAsERPUser(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\AppLoginService.cs:行号 34
   在 ERP.Winform.SysModule.LoginForm.btnLogin_Click(Object sender, EventArgs e) 位置 E:\winform\KQProject\ERPClient\ERP.Winform\SysModule\LoginForm.cs:行号 119
   在 System.Windows.Forms.Control.OnClick(EventArgs e)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 10,N'2014/12/23 15:32:57',N'1',N'WARN',N'ERP.Winform.Service.LogServive',N'用户名不存在',N'Util.AppException: 用户名不存在
   在 ERP.Service.tb_Sys_UserService.CheckUserPassword(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\tb_Sys_User.cs:行号 93
   在 ERP.Service.AppLoginService.LoginAsERPUser(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\AppLoginService.cs:行号 34
   在 ERP.Winform.SysModule.LoginForm.btnLogin_Click(Object sender, EventArgs e) 位置 E:\winform\KQProject\ERPClient\ERP.Winform\SysModule\LoginForm.cs:行号 119
   在 System.Windows.Forms.Control.OnClick(EventArgs e)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 11,N'2014/12/23 15:33:01',N'1',N'WARN',N'ERP.Winform.Service.LogServive',N'用户名或密码错误',N'Util.AppException: 用户名或密码错误
   在 ERP.Service.tb_Sys_UserService.CheckUserPassword(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\tb_Sys_User.cs:行号 95
   在 ERP.Service.AppLoginService.LoginAsERPUser(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\AppLoginService.cs:行号 34
   在 ERP.Winform.SysModule.LoginForm.btnLogin_Click(Object sender, EventArgs e) 位置 E:\winform\KQProject\ERPClient\ERP.Winform\SysModule\LoginForm.cs:行号 119
   在 System.Windows.Forms.Control.OnClick(EventArgs e)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 12,N'2014/12/23 15:33:06',N'1',N'WARN',N'ERP.Winform.Service.LogServive',N'用户名或密码错误',N'Util.AppException: 用户名或密码错误
   在 ERP.Service.tb_Sys_UserService.CheckUserPassword(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\tb_Sys_User.cs:行号 95
   在 ERP.Service.AppLoginService.LoginAsERPUser(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\AppLoginService.cs:行号 34
   在 ERP.Winform.SysModule.LoginForm.btnLogin_Click(Object sender, EventArgs e) 位置 E:\winform\KQProject\ERPClient\ERP.Winform\SysModule\LoginForm.cs:行号 119
   在 System.Windows.Forms.Control.OnClick(EventArgs e)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 13,N'2014/12/23 15:33:07',N'1',N'WARN',N'ERP.Winform.Service.LogServive',N'用户名或密码错误',N'Util.AppException: 用户名或密码错误
   在 ERP.Service.tb_Sys_UserService.CheckUserPassword(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\tb_Sys_User.cs:行号 95
   在 ERP.Service.AppLoginService.LoginAsERPUser(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\AppLoginService.cs:行号 34
   在 ERP.Winform.SysModule.LoginForm.btnLogin_Click(Object sender, EventArgs e) 位置 E:\winform\KQProject\ERPClient\ERP.Winform\SysModule\LoginForm.cs:行号 119
   在 System.Windows.Forms.Control.OnClick(EventArgs e)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 14,N'2014/12/23 16:00:56',N'1',N'WARN',N'ERP.Winform.Service.LogServive',N'用户名或密码错误',N'Util.AppException: 用户名或密码错误
   在 ERP.Service.tb_Sys_UserService.CheckUserPassword(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\tb_Sys_User.cs:行号 95
   在 ERP.Service.AppLoginService.LoginAsERPUser(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\AppLoginService.cs:行号 34
   在 ERP.Winform.SysModule.LoginForm.btnLogin_Click(Object sender, EventArgs e) 位置 E:\winform\KQProject\ERPClient\ERP.Winform\SysModule\LoginForm.cs:行号 120
   在 System.Windows.Forms.Control.OnClick(EventArgs e)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 15,N'2014/12/23 16:01:00',N'1',N'WARN',N'ERP.Winform.Service.LogServive',N'用户名不存在',N'Util.AppException: 用户名不存在
   在 ERP.Service.tb_Sys_UserService.CheckUserPassword(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\tb_Sys_User.cs:行号 93
   在 ERP.Service.AppLoginService.LoginAsERPUser(String userCode, String password) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\AppLoginService.cs:行号 34
   在 ERP.Winform.SysModule.LoginForm.btnLogin_Click(Object sender, EventArgs e) 位置 E:\winform\KQProject\ERPClient\ERP.Winform\SysModule\LoginForm.cs:行号 120
   在 System.Windows.Forms.Control.OnClick(EventArgs e)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 16,N'2014/12/25 14:03:53',N'10',N'WARN',N'ERP.Winform.Service.LogServive',N'密码不能为空',N'Util.AppException: 密码不能为空
   在 Util.ValidationHandler.Handle(ValidationResultCollection results) 位置 E:\winform\KQProject\Utils\Util\Validations\ValidationHandler.cs:行号 21
   在 COM.Domain.DomainBase.HandlerValidationResult(ValidationResultCollection results) 位置 E:\winform\KQProject\Utils\COM.Net\COM.Domain\Entity\DomainBase.cs:行号 115
   在 COM.Domain.DomainBase.Validate() 位置 E:\winform\KQProject\Utils\COM.Net\COM.Domain\Entity\DomainBase.cs:行号 105
   在 ERP.Service.tb_Sys_UserService.Createtb_Sys_User(tb_Sys_User tb_Sys_User) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\tb_Sys_User.cs:行号 45
   在 ERP.Winform.SysModule.SysUserEditForm.OnBtnCommand(Object sender, ItemClickEventArgs e) 位置 E:\winform\KQProject\ERPClient\ERP.Winform\SysModule\SysUserEditForm.cs:行号 47
   在 DevExpress.XtraBars.BarItem.OnClick(BarItemLink link)
   在 DevExpress.XtraBars.BarButtonItem.OnClick(BarItemLink link)
   在 DevExpress.XtraBars.BarItemLink.OnLinkClick()
   在 DevExpress.XtraBars.BarButtonItemLink.OnLinkClick()
   在 DevExpress.XtraBars.BarItemLink.OnLinkAction(BarLinkAction action, Object actionArgs)
   在 DevExpress.XtraBars.BarButtonItemLink.OnLinkAction(BarLinkAction action, Object actionArgs)
   在 DevExpress.XtraBars.BarItemLink.OnLinkActionCore(BarLinkAction action, Object actionArgs)
   在 DevExpress.XtraBars.ViewInfo.BarSelectionInfo.ClickLink(BarItemLink link)
   在 DevExpress.XtraBars.ViewInfo.BarSelectionInfo.UnPressLink(BarItemLink link)
   在 DevExpress.XtraBars.Controls.CustomLinksControl.OnMouseUp(MouseEventArgs e)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 DevExpress.XtraBars.Controls.DockedBarControl.WndProc(Message& msg)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 17,N'2014/12/25 14:25:08',N'9',N'WARN',N'ERP.Winform.Service.LogServive',N'密码不能为空',N'Util.AppException: 密码不能为空
   在 Util.ValidationHandler.Handle(ValidationResultCollection results) 位置 E:\winform\KQProject\Utils\Util\Validations\ValidationHandler.cs:行号 21
   在 COM.Domain.DomainBase.HandlerValidationResult(ValidationResultCollection results) 位置 E:\winform\KQProject\Utils\COM.Net\COM.Domain\Entity\DomainBase.cs:行号 115
   在 COM.Domain.DomainBase.Validate() 位置 E:\winform\KQProject\Utils\COM.Net\COM.Domain\Entity\DomainBase.cs:行号 105
   在 ERP.Service.tb_Sys_UserService.Createtb_Sys_User(tb_Sys_User tb_Sys_User) 位置 E:\winform\KQProject\ERPClient\ERP.Service\System\tb_Sys_User.cs:行号 45
   在 ERP.Winform.SysModule.SysUserEditForm.OnBtnCommand(Object sender, ItemClickEventArgs e) 位置 E:\winform\KQProject\ERPClient\ERP.Winform\SysModule\SysUserEditForm.cs:行号 48
   在 DevExpress.XtraBars.BarItem.OnClick(BarItemLink link)
   在 DevExpress.XtraBars.BarButtonItem.OnClick(BarItemLink link)
   在 DevExpress.XtraBars.BarItemLink.OnLinkClick()
   在 DevExpress.XtraBars.BarButtonItemLink.OnLinkClick()
   在 DevExpress.XtraBars.BarItemLink.OnLinkAction(BarLinkAction action, Object actionArgs)
   在 DevExpress.XtraBars.BarButtonItemLink.OnLinkAction(BarLinkAction action, Object actionArgs)
   在 DevExpress.XtraBars.BarItemLink.OnLinkActionCore(BarLinkAction action, Object actionArgs)
   在 DevExpress.XtraBars.ViewInfo.BarSelectionInfo.ClickLink(BarItemLink link)
   在 DevExpress.XtraBars.ViewInfo.BarSelectionInfo.UnPressLink(BarItemLink link)
   在 DevExpress.XtraBars.Controls.CustomLinksControl.OnMouseUp(MouseEventArgs e)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 DevExpress.XtraBars.Controls.DockedBarControl.WndProc(Message& msg)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 18,N'2014/12/27 15:16:44',N'9',N'ERROR',N'ERP.Winform.Service.LogServive',N'{Name属性验证失败=公司名称不能为空}',N'COM.Data.EfValidationException: 验证失败: ---> System.Data.Entity.Validation.DbEntityValidationException: Validation failed for one or more entities. See ''EntityValidationErrors'' property for more details.
   在 System.Data.Entity.Internal.InternalContext.SaveChanges()
   在 System.Data.Entity.Internal.LazyInternalContext.SaveChanges()
   在 System.Data.Entity.DbContext.SaveChanges()
   在 COM.Data.UnitOfWorkBase`1.Commit() 位置 E:\程序\KQProject\Utils\COM.Net\COM.Data\Repository\UnitOfWorkBase.cs:行号 30
   --- 内部异常堆栈跟踪的结尾 ---
   在 COM.Data.UnitOfWorkBase`1.Commit() 位置 E:\程序\KQProject\Utils\COM.Net\COM.Data\Repository\UnitOfWorkBase.cs:行号 38
   在 ERP.Service.CompanyService.Create(tb_C001_Company tb_C001_Company) 位置 E:\程序\KQProject\ERPClient\ERP.Service\Common\tb_C001_Company.cs:行号 42
   在 ERP.Winform.CommonModule.CompanyEditForm.OnBtnCommand(Object sender, ItemClickEventArgs e) 位置 E:\程序\KQProject\ERPClient\ERP.Winform\CommonModule\CompanyEditForm.cs:行号 41
   在 DevExpress.XtraBars.BarItem.OnClick(BarItemLink link)
   在 DevExpress.XtraBars.BarBaseButtonItem.OnClick(BarItemLink link)
   在 DevExpress.XtraBars.BarButtonItem.OnClick(BarItemLink link)
   在 DevExpress.XtraBars.BarItemLink.OnLinkClick()
   在 DevExpress.XtraBars.BarButtonItemLink.OnLinkClick()
   在 DevExpress.XtraBars.BarItemLink.OnLinkAction(BarLinkAction action, Object actionArgs)
   在 DevExpress.XtraBars.BarButtonItemLink.OnLinkAction(BarLinkAction action, Object actionArgs)
   在 DevExpress.XtraBars.BarItemLink.OnLinkActionCore(BarLinkAction action, Object actionArgs)
   在 DevExpress.XtraBars.ViewInfo.BarSelectionInfo.ClickLink(BarItemLink link)
   在 DevExpress.XtraBars.ViewInfo.BarSelectionInfo.UnPressLink(BarItemLink link)
   在 DevExpress.XtraBars.Controls.CustomLinksControl.OnMouseUp(MouseEventArgs e)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 DevExpress.XtraBars.Controls.DockedBarControl.')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 19,N'2014/12/27 15:28:46',N'1',N'WARN',N'ERP.Winform.Service.LogServive',N'公司名称不能为空',N'Util.AppException: 公司名称不能为空
   在 Util.ValidationHandler.Handle(ValidationResultCollection results) 位置 E:\程序\KQProject\Utils\Util\Validations\ValidationHandler.cs:行号 21
   在 COM.Domain.DomainBase.HandlerValidationResult(ValidationResultCollection results) 位置 E:\程序\KQProject\Utils\COM.Net\COM.Domain\Entity\DomainBase.cs:行号 115
   在 COM.Domain.DomainBase.Validate() 位置 E:\程序\KQProject\Utils\COM.Net\COM.Domain\Entity\DomainBase.cs:行号 105
   在 ERP.Service.CompanyService.Create(tb_C001_Company tb_C001_Company) 位置 E:\程序\KQProject\ERPClient\ERP.Service\Common\tb_C001_Company.cs:行号 41
   在 ERP.Winform.CommonModule.CompanyEditForm.OnBtnCommand(Object sender, ItemClickEventArgs e) 位置 E:\程序\KQProject\ERPClient\ERP.Winform\CommonModule\CompanyEditForm.cs:行号 41
   在 DevExpress.XtraBars.BarItem.OnClick(BarItemLink link)
   在 DevExpress.XtraBars.BarBaseButtonItem.OnClick(BarItemLink link)
   在 DevExpress.XtraBars.BarButtonItem.OnClick(BarItemLink link)
   在 DevExpress.XtraBars.BarItemLink.OnLinkClick()
   在 DevExpress.XtraBars.BarButtonItemLink.OnLinkClick()
   在 DevExpress.XtraBars.BarItemLink.OnLinkAction(BarLinkAction action, Object actionArgs)
   在 DevExpress.XtraBars.BarButtonItemLink.OnLinkAction(BarLinkAction action, Object actionArgs)
   在 DevExpress.XtraBars.BarItemLink.OnLinkActionCore(BarLinkAction action, Object actionArgs)
   在 DevExpress.XtraBars.ViewInfo.BarSelectionInfo.ClickLink(BarItemLink link)
   在 DevExpress.XtraBars.ViewInfo.BarSelectionInfo.UnPressLink(BarItemLink link)
   在 DevExpress.XtraBars.Controls.CustomLinksControl.OnMouseUp(MouseEventArgs e)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 DevExpress.XtraBars.Controls.DockedBarControl.WndProc(Message& msg)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Windows.Forms.Na')
INSERT [tb_Sys_Logs] ([Id],[Date],[Thread],[Log_level],[Logger],[Message],[Exception]) VALUES ( 20,N'2014/12/28 0:29:51',N'9',N'WARN',N'ERP.Winform.Service.LogServive',N'公司名称不能为空',N'Util.AppException: 公司名称不能为空
   在 Util.ValidationHandler.Handle(ValidationResultCollection results) 位置 E:\程序\KQProject\Utils\Util\Validations\ValidationHandler.cs:行号 21
   在 COM.Domain.DomainBase.HandlerValidationResult(ValidationResultCollection results) 位置 E:\程序\KQProject\Utils\COM.Net\COM.Domain\Entity\DomainBase.cs:行号 115
   在 COM.Domain.DomainBase.Validate() 位置 E:\程序\KQProject\Utils\COM.Net\COM.Domain\Entity\DomainBase.cs:行号 105
   在 ERP.Service.tb_C005_EmployeeService.Create(tb_C005_Employee tb_C005_Employee) 位置 E:\程序\KQProject\ERPClient\ERP.Service\Common\tb_C005_Employee.cs:行号 43
   在 ERP.Winform.CommonModule.EmployeeEditForm.OnBtnCommand(Object sender, ItemClickEventArgs e) 位置 E:\程序\KQProject\ERPClient\ERP.Winform\CommonModule\EmployeeEditForm.cs:行号 43
   在 DevExpress.XtraBars.BarItem.OnClick(BarItemLink link)
   在 DevExpress.XtraBars.BarBaseButtonItem.OnClick(BarItemLink link)
   在 DevExpress.XtraBars.BarButtonItem.OnClick(BarItemLink link)
   在 DevExpress.XtraBars.BarItemLink.OnLinkClick()
   在 DevExpress.XtraBars.BarButtonItemLink.OnLinkClick()
   在 DevExpress.XtraBars.BarItemLink.OnLinkAction(BarLinkAction action, Object actionArgs)
   在 DevExpress.XtraBars.BarButtonItemLink.OnLinkAction(BarLinkAction action, Object actionArgs)
   在 DevExpress.XtraBars.BarItemLink.OnLinkActionCore(BarLinkAction action, Object actionArgs)
   在 DevExpress.XtraBars.ViewInfo.BarSelectionInfo.ClickLink(BarItemLink link)
   在 DevExpress.XtraBars.ViewInfo.BarSelectionInfo.UnPressLink(BarItemLink link)
   在 DevExpress.XtraBars.Controls.CustomLinksControl.OnMouseUp(MouseEventArgs e)
   在 System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   在 System.Windows.Forms.Control.WndProc(Message& m)
   在 DevExpress.XtraBars.Controls.DockedBarControl.WndProc(Message& msg)
   在 System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   在 System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   在 System.Wi')

SET IDENTITY_INSERT [tb_Sys_Logs] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[tb_Sys_Menu]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_Sys_Menu]

CREATE TABLE [tb_Sys_Menu] (
[Id] [uniqueidentifier]  NOT NULL,
[MenuName] [nvarchar]  (50) NULL,
[MenuIcon] [image]  NULL,
[ParentMenuId] [uniqueidentifier]  NULL,
[NameSpeace] [nvarchar]  (100) NULL,
[SeqNo] [nvarchar]  (50) NULL,
[Version] [timestamp]  NULL,
[CreateTime] [datetime]  NULL,
[ModifyTime] [datetime]  NULL,
[CreateUser] [nvarchar]  (50) NULL,
[ModifyUser] [nvarchar]  (50) NULL)

ALTER TABLE [tb_Sys_Menu] WITH NOCHECK ADD  CONSTRAINT [PK_tb_Sys_Menu] PRIMARY KEY  NONCLUSTERED ( [Id] )
INSERT [tb_Sys_Menu] ([Id],[MenuName],[MenuIcon],[ParentMenuId],[NameSpeace],[SeqNo],[Version],[ModifyTime],[ModifyUser]) VALUES ( N'8964f57d-d1bd-40ac-ab37-04a3f13a7b1e',N'系统用户',System.Byte[],N'de98b16c-bbcd-4d0b-b02a-b6c54cc3972d',N'ERP.Winform.SysModule.SysUserForm',N'01',System.Byte[],N'2014/12/28 0:36:55',N'admin')
INSERT [tb_Sys_Menu] ([Id],[MenuName],[MenuIcon],[ParentMenuId],[NameSpeace],[SeqNo],[Version],[ModifyTime],[ModifyUser]) VALUES ( N'2235f350-1778-4760-84bb-12298f88ed2b',N'公司管理',System.Byte[],N'44848e77-d95e-4f95-8b93-843db0269d26',N'ERP.Winform.CommonModule.CompanyForm',N'01',System.Byte[],N'2014/12/28 0:37:04',N'admin')
INSERT [tb_Sys_Menu] ([Id],[MenuName],[MenuIcon],[ParentMenuId],[NameSpeace],[SeqNo],[Version],[ModifyTime],[ModifyUser]) VALUES ( N'aa4e9d45-a015-45d9-810e-5559adb86623',N'权限管理',System.Byte[],N'de98b16c-bbcd-4d0b-b02a-b6c54cc3972d',N'ERP.Winform.A004_RoleControl',N'05',System.Byte[],N'2014/12/28 0:40:01',N'admin')
INSERT [tb_Sys_Menu] ([Id],[MenuName],[MenuIcon],[ParentMenuId],[NameSpeace],[SeqNo],[Version],[ModifyTime],[ModifyUser]) VALUES ( N'67c2d8dd-df2f-48ed-b2db-5c613728109a',N'系统菜单',System.Byte[],N'de98b16c-bbcd-4d0b-b02a-b6c54cc3972d',N'ERP.Winform.SysModule.SysMenuForm',N'03',System.Byte[],N'2014/12/28 0:38:42',N'admin')
INSERT [tb_Sys_Menu] ([Id],[MenuName],[MenuIcon],[ParentMenuId],[NameSpeace],[SeqNo],[Version],[ModifyTime],[ModifyUser]) VALUES ( N'5fe293de-e791-44de-9c98-6bb0b41d02db',N'系统角色',System.Byte[],N'de98b16c-bbcd-4d0b-b02a-b6c54cc3972d',N'ERP.Winform.SysModule.SysRoleForm',N'02',System.Byte[],N'2014/12/28 0:39:26',N'admin')
INSERT [tb_Sys_Menu] ([Id],[MenuName],[MenuIcon],[NameSpeace],[SeqNo],[Version],[ModifyTime],[ModifyUser]) VALUES ( N'44848e77-d95e-4f95-8b93-843db0269d26',N'基本模块',System.Byte[],N'ERP.Winform.SysModule.HomeForm',N'01',System.Byte[],N'2014/12/28 0:40:47',N'admin')
INSERT [tb_Sys_Menu] ([Id],[MenuName],[MenuIcon],[ParentMenuId],[NameSpeace],[SeqNo],[Version],[ModifyTime],[ModifyUser]) VALUES ( N'2efc9836-d2ec-43b2-961d-854ea271a3ef',N'系统按钮',System.Byte[],N'de98b16c-bbcd-4d0b-b02a-b6c54cc3972d',N'ERP.Winform.SysModule.SysButtonForm',N'04',System.Byte[],N'2014/12/28 0:38:49',N'admin')
INSERT [tb_Sys_Menu] ([Id],[MenuName],[MenuIcon],[NameSpeace],[SeqNo],[Version]) VALUES ( N'de98b16c-bbcd-4d0b-b02a-b6c54cc3972d',N'系统设置',System.Byte[],N'ERP.Winform.SysModule.HomeForm',N'02',System.Byte[])
INSERT [tb_Sys_Menu] ([Id],[MenuName],[MenuIcon],[ParentMenuId],[NameSpeace],[SeqNo],[Version]) VALUES ( N'251ed296-45b3-4fc4-b32c-c83c2657ee31',N'员工管理',System.Byte[],N'44848e77-d95e-4f95-8b93-843db0269d26',N'ERP.Winform.CommonModule.EmployeeForm',N'05',System.Byte[])
if exists (select * from sysobjects where id = OBJECT_ID('[tb_Sys_Roles]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_Sys_Roles]

CREATE TABLE [tb_Sys_Roles] (
[Id] [uniqueidentifier]  NOT NULL,
[Roles_Name] [nvarchar]  (50) NULL,
[Roles_Remark] [nvarchar]  (50) NULL,
[Version] [timestamp]  NULL,
[CreateTime] [datetime]  NULL,
[ModifyTime] [datetime]  NULL,
[CreateUser] [nvarchar]  (50) NULL,
[ModifyUser] [nvarchar]  (50) NULL)

ALTER TABLE [tb_Sys_Roles] WITH NOCHECK ADD  CONSTRAINT [PK_tb_Sys_Roles] PRIMARY KEY  NONCLUSTERED ( [Id] )
INSERT [tb_Sys_Roles] ([Id],[Roles_Name],[Version]) VALUES ( N'4a49e065-86e3-43f0-bab9-18b4881c9afd',N'一般用户',System.Byte[])
INSERT [tb_Sys_Roles] ([Id],[Roles_Name],[Version]) VALUES ( N'f049670f-138f-4e45-a3b5-7d302c087cc1',N'测试用户',System.Byte[])
INSERT [tb_Sys_Roles] ([Id],[Roles_Name],[Roles_Remark],[Version]) VALUES ( N'228cf9fe-0f11-46de-b39c-895705415d53',N'管理员',N'test',System.Byte[])
if exists (select * from sysobjects where id = OBJECT_ID('[tb_Sys_RolesBtn]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_Sys_RolesBtn]

CREATE TABLE [tb_Sys_RolesBtn] (
[Id] [uniqueidentifier]  NOT NULL,
[Roles_Id] [uniqueidentifier]  NULL,
[Menu_Id] [uniqueidentifier]  NULL,
[Btn_Id] [uniqueidentifier]  NULL,
[Version] [timestamp]  NULL,
[CreateTime] [datetime]  NULL)

ALTER TABLE [tb_Sys_RolesBtn] WITH NOCHECK ADD  CONSTRAINT [PK_tb_Sys_RolesBtn] PRIMARY KEY  NONCLUSTERED ( [Id] )
INSERT [tb_Sys_RolesBtn] ([Id],[Roles_Id],[Menu_Id],[Btn_Id],[Version]) VALUES ( N'c4d59d64-730d-4ca0-aa6e-062acf996434',N'228cf9fe-0f11-46de-b39c-895705415d53',N'251ed296-45b3-4fc4-b32c-c83c2657ee31',N'7f870b14-7373-490b-9a9c-ed9520d05ea7',System.Byte[])
INSERT [tb_Sys_RolesBtn] ([Id],[Roles_Id],[Menu_Id],[Btn_Id],[Version]) VALUES ( N'3a981651-58fa-48c1-8c5b-1ac3ed1accdb',N'228cf9fe-0f11-46de-b39c-895705415d53',N'251ed296-45b3-4fc4-b32c-c83c2657ee31',N'205607e5-e93d-4226-8dae-e8c6b8e8927c',System.Byte[])
INSERT [tb_Sys_RolesBtn] ([Id],[Roles_Id],[Menu_Id],[Btn_Id],[Version]) VALUES ( N'fe1fb9a9-19a1-4194-9428-1e190661db4e',N'228cf9fe-0f11-46de-b39c-895705415d53',N'2efc9836-d2ec-43b2-961d-854ea271a3ef',N'7f870b14-7373-490b-9a9c-ed9520d05ea7',System.Byte[])
INSERT [tb_Sys_RolesBtn] ([Id],[Roles_Id],[Menu_Id],[Btn_Id],[Version]) VALUES ( N'b3e04554-02db-4528-81ca-2199348cb4c4',N'228cf9fe-0f11-46de-b39c-895705415d53',N'8964f57d-d1bd-40ac-ab37-04a3f13a7b1e',N'7f870b14-7373-490b-9a9c-ed9520d05ea7',System.Byte[])
INSERT [tb_Sys_RolesBtn] ([Id],[Roles_Id],[Menu_Id],[Btn_Id],[Version]) VALUES ( N'010fdfbc-1605-492c-81ce-2b9988d88c04',N'228cf9fe-0f11-46de-b39c-895705415d53',N'2efc9836-d2ec-43b2-961d-854ea271a3ef',N'5fbdd22f-a938-47a2-946f-1d79b76ba960',System.Byte[])
INSERT [tb_Sys_RolesBtn] ([Id],[Roles_Id],[Menu_Id],[Btn_Id],[Version]) VALUES ( N'7a32e5e9-1f76-4071-b9ca-38c0f99ec71e',N'228cf9fe-0f11-46de-b39c-895705415d53',N'2235f350-1778-4760-84bb-12298f88ed2b',N'7f870b14-7373-490b-9a9c-ed9520d05ea7',System.Byte[])
INSERT [tb_Sys_RolesBtn] ([Id],[Roles_Id],[Menu_Id],[Btn_Id],[Version]) VALUES ( N'a9434818-39cf-4b55-be5b-3f15c8b1d6a2',N'228cf9fe-0f11-46de-b39c-895705415d53',N'5fe293de-e791-44de-9c98-6bb0b41d02db',N'5fbdd22f-a938-47a2-946f-1d79b76ba960',System.Byte[])
INSERT [tb_Sys_RolesBtn] ([Id],[Roles_Id],[Menu_Id],[Btn_Id],[Version]) VALUES ( N'6f9ebb04-632c-4602-b2c8-41d0e385d329',N'228cf9fe-0f11-46de-b39c-895705415d53',N'251ed296-45b3-4fc4-b32c-c83c2657ee31',N'5fbdd22f-a938-47a2-946f-1d79b76ba960',System.Byte[])
INSERT [tb_Sys_RolesBtn] ([Id],[Roles_Id],[Menu_Id],[Btn_Id],[Version]) VALUES ( N'15db4279-8f11-42e6-a26e-5751a5e65816',N'228cf9fe-0f11-46de-b39c-895705415d53',N'67c2d8dd-df2f-48ed-b2db-5c613728109a',N'7f870b14-7373-490b-9a9c-ed9520d05ea7',System.Byte[])
INSERT [tb_Sys_RolesBtn] ([Id],[Roles_Id],[Menu_Id],[Btn_Id],[Version]) VALUES ( N'254c06a1-3950-44be-af7b-869fd0330743',N'228cf9fe-0f11-46de-b39c-895705415d53',N'8964f57d-d1bd-40ac-ab37-04a3f13a7b1e',N'5fbdd22f-a938-47a2-946f-1d79b76ba960',System.Byte[])
INSERT [tb_Sys_RolesBtn] ([Id],[Roles_Id],[Menu_Id],[Btn_Id],[Version]) VALUES ( N'8e3b0b6b-8255-4cb1-b729-94e25e3f86a1',N'228cf9fe-0f11-46de-b39c-895705415d53',N'2235f350-1778-4760-84bb-12298f88ed2b',N'205607e5-e93d-4226-8dae-e8c6b8e8927c',System.Byte[])
INSERT [tb_Sys_RolesBtn] ([Id],[Roles_Id],[Menu_Id],[Btn_Id],[Version]) VALUES ( N'690fd219-f548-41ab-92f5-dca4728ebaf8',N'228cf9fe-0f11-46de-b39c-895705415d53',N'67c2d8dd-df2f-48ed-b2db-5c613728109a',N'5fbdd22f-a938-47a2-946f-1d79b76ba960',System.Byte[])
INSERT [tb_Sys_RolesBtn] ([Id],[Roles_Id],[Menu_Id],[Btn_Id],[Version]) VALUES ( N'55c0ca99-c5bd-409c-ba9b-e2bfcf355ba9',N'228cf9fe-0f11-46de-b39c-895705415d53',N'2235f350-1778-4760-84bb-12298f88ed2b',N'5fbdd22f-a938-47a2-946f-1d79b76ba960',System.Byte[])
INSERT [tb_Sys_RolesBtn] ([Id],[Roles_Id],[Menu_Id],[Btn_Id],[Version]) VALUES ( N'85d59cf1-a59a-48cb-8030-e48c8f31f139',N'228cf9fe-0f11-46de-b39c-895705415d53',N'8964f57d-d1bd-40ac-ab37-04a3f13a7b1e',N'205607e5-e93d-4226-8dae-e8c6b8e8927c',System.Byte[])
INSERT [tb_Sys_RolesBtn] ([Id],[Roles_Id],[Menu_Id],[Btn_Id],[Version]) VALUES ( N'7635ef92-75b7-43d7-b43f-f96bf4abb1c3',N'228cf9fe-0f11-46de-b39c-895705415d53',N'5fe293de-e791-44de-9c98-6bb0b41d02db',N'7f870b14-7373-490b-9a9c-ed9520d05ea7',System.Byte[])
if exists (select * from sysobjects where id = OBJECT_ID('[tb_Sys_RolesRight]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_Sys_RolesRight]

CREATE TABLE [tb_Sys_RolesRight] (
[Id] [uniqueidentifier]  NOT NULL,
[Roles_Id] [uniqueidentifier]  NULL,
[Menu_Id] [uniqueidentifier]  NULL,
[Version] [timestamp]  NULL,
[CreateTime] [datetime]  NULL,
[CreateUser] [nvarchar]  (50) NULL)

ALTER TABLE [tb_Sys_RolesRight] WITH NOCHECK ADD  CONSTRAINT [PK_tb_Sys_RolesRight] PRIMARY KEY  NONCLUSTERED ( [Id] )
INSERT [tb_Sys_RolesRight] ([Id],[Roles_Id],[Menu_Id],[Version]) VALUES ( N'4ef0d71e-74ef-4b5a-b71d-19be60eb9a63',N'228cf9fe-0f11-46de-b39c-895705415d53',N'44848e77-d95e-4f95-8b93-843db0269d26',System.Byte[])
INSERT [tb_Sys_RolesRight] ([Id],[Roles_Id],[Menu_Id],[Version]) VALUES ( N'b6ea0a17-c0bb-4f82-ace6-2cc8f84ed71d',N'228cf9fe-0f11-46de-b39c-895705415d53',N'31fcf869-5d5b-4cde-a50d-a1fba914cf05',System.Byte[])
INSERT [tb_Sys_RolesRight] ([Id],[Roles_Id],[Menu_Id],[Version]) VALUES ( N'631185ee-d4ad-41b8-979d-753f29a7c066',N'228cf9fe-0f11-46de-b39c-895705415d53',N'2efc9836-d2ec-43b2-961d-854ea271a3ef',System.Byte[])
INSERT [tb_Sys_RolesRight] ([Id],[Roles_Id],[Menu_Id],[Version]) VALUES ( N'69573c93-ac7c-40cf-b4f4-96d9a309aabb',N'228cf9fe-0f11-46de-b39c-895705415d53',N'67c2d8dd-df2f-48ed-b2db-5c613728109a',System.Byte[])
INSERT [tb_Sys_RolesRight] ([Id],[Roles_Id],[Menu_Id],[Version]) VALUES ( N'86863210-f851-4028-af77-acf01bb5332b',N'228cf9fe-0f11-46de-b39c-895705415d53',N'5fe293de-e791-44de-9c98-6bb0b41d02db',System.Byte[])
INSERT [tb_Sys_RolesRight] ([Id],[Roles_Id],[Menu_Id],[Version]) VALUES ( N'fc10ff42-7b96-441c-b619-b7bb1ae06546',N'228cf9fe-0f11-46de-b39c-895705415d53',N'2235f350-1778-4760-84bb-12298f88ed2b',System.Byte[])
INSERT [tb_Sys_RolesRight] ([Id],[Roles_Id],[Menu_Id],[Version]) VALUES ( N'c0ce0e3c-4960-4c26-b397-e94f10f17f3e',N'228cf9fe-0f11-46de-b39c-895705415d53',N'de98b16c-bbcd-4d0b-b02a-b6c54cc3972d',System.Byte[])
INSERT [tb_Sys_RolesRight] ([Id],[Roles_Id],[Menu_Id],[Version]) VALUES ( N'502707dd-c760-4394-ab50-f29bbf867f2b',N'228cf9fe-0f11-46de-b39c-895705415d53',N'251ed296-45b3-4fc4-b32c-c83c2657ee31',System.Byte[])
INSERT [tb_Sys_RolesRight] ([Id],[Roles_Id],[Menu_Id],[Version]) VALUES ( N'8aa66a75-5e53-4cc8-a473-fb055b8740af',N'228cf9fe-0f11-46de-b39c-895705415d53',N'8964f57d-d1bd-40ac-ab37-04a3f13a7b1e',System.Byte[])
if exists (select * from sysobjects where id = OBJECT_ID('[tb_Sys_User]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_Sys_User]

CREATE TABLE [tb_Sys_User] (
[Id] [uniqueidentifier]  NOT NULL,
[UserCode] [nvarchar]  (20) NULL,
[UserName] [nvarchar]  (30) NULL,
[UserPassword] [nvarchar]  (50) NULL,
[Version] [timestamp]  NULL,
[CreateTime] [datetime]  NULL,
[ModifyTime] [datetime]  NULL,
[Createuser] [nvarchar]  (50) NULL,
[ModifyUser] [nvarchar]  (50) NULL)

ALTER TABLE [tb_Sys_User] WITH NOCHECK ADD  CONSTRAINT [PK_tb_Sys_User] PRIMARY KEY  NONCLUSTERED ( [Id] )
INSERT [tb_Sys_User] ([Id],[UserCode],[UserName],[UserPassword],[Version]) VALUES ( N'2fb58b97-7031-40ef-8dba-247ada96aaf0',N'dd',N'dd',N'dd',System.Byte[])
INSERT [tb_Sys_User] ([Id],[UserCode],[UserName],[UserPassword],[Version]) VALUES ( N'68fc502a-8eb5-4e26-b059-25073bc9508b',N'123233',N'111333',N'111333',System.Byte[])
INSERT [tb_Sys_User] ([Id],[UserCode],[UserName],[UserPassword],[Version]) VALUES ( N'56644d86-c4bf-4049-abf2-525a99449066',N'111',N'111',N'111',System.Byte[])
INSERT [tb_Sys_User] ([Id],[UserCode],[UserName],[UserPassword],[Version]) VALUES ( N'199f7d2b-68ce-4694-9f99-64a430085442',N'admin',N'admin',N'admin',System.Byte[])
INSERT [tb_Sys_User] ([Id],[UserCode],[UserName],[UserPassword],[Version]) VALUES ( N'fbdb0a9a-19c0-4909-9711-c91bf6205b07',N'yk',N'ykd',N'yk',System.Byte[])
if exists (select * from sysobjects where id = OBJECT_ID('[tb_Sys_UserRole]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [tb_Sys_UserRole]

CREATE TABLE [tb_Sys_UserRole] (
[Id] [uniqueidentifier]  NOT NULL,
[UserId] [uniqueidentifier]  NULL,
[RoleId] [uniqueidentifier]  NULL,
[Version] [timestamp]  NULL,
[CreateTime] [datetime]  NULL)

ALTER TABLE [tb_Sys_UserRole] WITH NOCHECK ADD  CONSTRAINT [PK_tb_Sys_UserRole] PRIMARY KEY  NONCLUSTERED ( [Id] )
INSERT [tb_Sys_UserRole] ([Id],[UserId],[RoleId],[Version]) VALUES ( N'db023969-98b1-4832-b216-ebe89076d88f',N'fbdb0a9a-19c0-4909-9711-c91bf6205b07',N'228cf9fe-0f11-46de-b39c-895705415d53',System.Byte[])
INSERT [tb_Sys_UserRole] ([Id],[UserId],[RoleId],[Version]) VALUES ( N'786a97a2-b6b3-4b39-864e-fe77626369d5',N'199f7d2b-68ce-4694-9f99-64a430085442',N'228cf9fe-0f11-46de-b39c-895705415d53',System.Byte[])
