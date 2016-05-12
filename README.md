# KQERP
个人winform项目
2016/5/6
跟踪单管理: 1.状态添加删除跟审核，删除跟踪单只更新状态，已审核不可删除 Y
		2.添加审核与反审核功能 Y
		3.跟踪单批次号排序 Y
		4.批量打印跟踪单报表 
		5.跟踪单报表工序名称模糊匹配
		6.数据库
alter table MES_M202_Task_Detail add Auditor nvarchar(50)
alter table MES_M202_Task_Detail add AuditingDt datetime


2016/5/10
1.新增表
CREATE TABLE [MES_M201_Plan_Daily] (
[Id] [uniqueidentifier]  NOT NULL,
[CompCode] [nvarchar]  (50) NULL,
[PLNo] [nvarchar]  (50) NULL,
[PlanDetailId] [uniqueidentifier]  (50) NULL,
[TxDt] [datetime]  NULL,
[Qty] [money]  NULL,
[Remarks] [nvarchar]  (50) NULL)

ALTER TABLE [MES_M201_Plan_Daily] WITH NOCHECK ADD  CONSTRAINT [PK_MES_M201_Plan_Daily] PRIMARY KEY  NONCLUSTERED ( [Id] )



2016/5/11
alter table MES_M201_Plan add Weekly nvarchar(20)
alter table MES_M201_Plan add PlanCompleteDt datetime
alter table MES_M201_Plan add PlanDeliveryDt datetime

2016/5/12
alter table ERP_M001_Product_PackInfo add CompName nvarchar(50)
alter table MES_M801_Label_L add CompName nvarchar(50)
alter table MES_M801_Label_L_PrintData add CompName nvarchar(50)
alter table MES_M801_Label_M add CompName nvarchar(50)
alter table MES_M801_Label_M_PrintData add CompName nvarchar(50)
alter table MES_M801_Label_S add CompName nvarchar(50)
alter table MES_M801_Label_S_PrintData add CompName nvarchar(50)