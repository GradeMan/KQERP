﻿# KQERP
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
