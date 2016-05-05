
cls
@echo off
rem move t4.cs to module dir

D:
cd D:\Project.SVN\MH.Net\ERP.MH\ERP.T4\T4

md ..\..\ERP.Domain\tb_Sys_User\Map
copy .\DomainMap\EntityMap.cs  ..\..\ERP.Domain\tb_Sys_User\Map\tb_Sys_UserMap.cs /y

md ..\..\ERP.Data\tb_Sys_User
copy .\Data\EntityRepository.cs  ..\..\ERP.Data\tb_Sys_User\tb_Sys_UserRepository.cs /y

md ..\..\ERP.Service\tb_Sys_User
copy .\Service\EntityService.cs  ..\..\ERP.Service\tb_Sys_User\tb_Sys_UserService.cs /y

md ..\..\..\tb_Sys_User.Net\tb_Sys_User.Web\tb_Sys_User
md ..\..\..\tb_Sys_User.Net\tb_Sys_User.Web\tb_Sys_User\Controllers
copy .\Web\Controller.cs  ..\..\..\tb_Sys_User.Net\tb_Sys_User.Web\tb_Sys_User\Controllers\tb_Sys_UserController.cs /y

md ..\..\..\tb_Sys_User.Net\tb_Sys_User.Web\tb_Sys_User\Views
md ..\..\..\tb_Sys_User.Net\tb_Sys_User.Web\tb_Sys_User\Views\tb_Sys_User
copy .\Web\List.cshtml  ..\..\..\tb_Sys_User.Net\tb_Sys_User.Web\tb_Sys_User\Views\tb_Sys_User\List.cshtml /y
copy .\Web\Edit.cshtml  ..\..\..\tb_Sys_User.Net\tb_Sys_User.Web\tb_Sys_User\Views\tb_Sys_User\Edit.cshtml /y

del .\DomainMap\*.cs  /q
del .\Data\*.cs  /q
del .\Service\*.cs  /q
del .\Web\*.cs  /q
del .\Web\*.cshtml  /q
del .\*.cs  /q
del .\*.bat /q

