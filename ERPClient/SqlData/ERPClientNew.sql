USE [ERPClient]
GO
/****** Object:  Table [dbo].[MES_M003_LotTx_NG]    Script Date: 12/31/2014 08:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MES_M003_LotTx_NG](
	[ID] [uniqueidentifier] NOT NULL,
	[CompCode] [nvarchar](3) NULL,
	[LotNo] [nvarchar](50) NULL,
	[ProcessCode] [nvarchar](50) NULL,
	[CriteriaCode] [nvarchar](50) NULL,
	[Qty] [money] NULL,
	[Remarks] [nvarchar](100) NULL,
	[ModifyDt] [datetime] NULL,
	[ModifyUser] [nvarchar](50) NULL,
	[CreateDt] [datetime] NULL,
	[CreateUser] [nvarchar](50) NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_MES_M003_LotTx_QC] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MES_M003_LotTx]    Script Date: 12/31/2014 08:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MES_M003_LotTx](
	[ID] [uniqueidentifier] NOT NULL,
	[CompCode] [nvarchar](3) NULL,
	[LotNo] [nvarchar](50) NULL,
	[ProcessCode] [nvarchar](50) NULL,
	[TxDt] [datetime] NULL,
	[ShiftCode] [nvarchar](50) NULL,
	[MacCode] [nvarchar](50) NULL,
	[Operator] [nvarchar](50) NULL,
	[InQty] [money] NULL,
	[OutQty] [money] NULL,
	[NGQty] [money] NULL,
	[Remarks] [nvarchar](200) NULL,
	[ModifyDt] [datetime] NULL,
	[ModifyUser] [nvarchar](50) NULL,
	[CreateDt] [datetime] NULL,
	[CreateUser] [nvarchar](50) NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_MES_M003_LotTx] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MES_M002_Job_Lot]    Script Date: 12/31/2014 08:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MES_M002_Job_Lot](
	[ID] [uniqueidentifier] NOT NULL,
	[CompCode] [nvarchar](3) NULL,
	[JobNo] [nvarchar](50) NULL,
	[LotNo] [nvarchar](50) NULL,
	[LotQty] [money] NULL,
	[Remarks] [nvarchar](50) NULL,
	[ModifyDt] [datetime] NULL,
	[ModifyUser] [nvarchar](50) NULL,
	[CreateDt] [datetime] NULL,
	[CreateUser] [nvarchar](50) NULL,
	[Version] [timestamp] NULL,
 CONSTRAINT [PK_MES_M002_Job_Lot] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MES_M002_Job]    Script Date: 12/31/2014 08:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MES_M002_Job](
	[Id] [uniqueidentifier] NOT NULL,
	[CompCode] [nvarchar](50) NULL,
	[JobNo] [nvarchar](50) NULL,
	[JobDt] [datetime] NULL,
	[JobType] [nvarchar](50) NULL,
	[FItemCode] [nvarchar](50) NULL,
	[ItemCode] [nvarchar](50) NULL,
	[OrderNo] [nvarchar](50) NULL,
	[CustCode] [nvarchar](50) NULL,
	[ProcessFlow] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
	[ProdTargetDt] [datetime] NULL,
	[IssueTargetDt] [datetime] NULL,
	[ApprovalDt] [datetime] NULL,
	[ApprovalBy] [nvarchar](50) NULL,
	[Remarks] [nvarchar](100) NULL,
	[ModifyDt] [datetime] NULL,
	[ModifyUser] [nvarchar](50) NULL,
	[CreateDt] [datetime] NULL,
	[CreateUser] [nvarchar](50) NULL,
	[JobQty] [money] NULL,
	[PQty] [money] NULL,
	[BCPQty] [money] NULL,
	[EQty] [money] NULL,
	[ZZCQty] [money] NULL,
	[CQty] [money] NULL,
	[QQty] [money] NULL,
	[CPQty] [money] NULL,
	[Version] [timestamp] NOT NULL,
 CONSTRAINT [PK_MES_M002_MPS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
