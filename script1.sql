USE [CoronaVirusDb]
GO
/****** Object:  Table [dbo].[coronaVirusDetails]    Script Date: 11/05/2023 22:59:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[coronaVirusDetails](
	[patientId] [varchar](9) NOT NULL,
	[vaccine1ReceiveTime] [date] NULL,
	[vaccine2ReceiveTime] [date] NULL,
	[vaccine3ReceiveTime] [date] NULL,
	[vaccine4ReceiveTime] [date] NULL,
	[positiveResultDate] [date] NULL,
	[recoveryDate] [date] NULL,
	[vaccine1Manufacturer] [varchar](30) NULL,
	[vaccine2Manufacturer] [varchar](30) NULL,
	[vaccine3Manufacturer] [varchar](30) NULL,
	[vaccine4Manufacturer] [varchar](30) NULL,
 CONSTRAINT [PK__CoronaVi__A17005EC7C90C3C6] PRIMARY KEY CLUSTERED 
(
	[patientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patients]    Script Date: 11/05/2023 22:59:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patients](
	[fullName] [varchar](30) NULL,
	[patientId] [varchar](9) NOT NULL,
	[address] [varchar](30) NULL,
	[city] [varchar](15) NULL,
	[birthDate] [date] NULL,
	[telephone] [varchar](15) NULL,
	[mobilePhone] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[patientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[coronaVirusDetails]  WITH CHECK ADD  CONSTRAINT [FK_CoronaVirusDetails_patients] FOREIGN KEY([patientId])
REFERENCES [dbo].[patients] ([patientId])
GO
ALTER TABLE [dbo].[coronaVirusDetails] CHECK CONSTRAINT [FK_CoronaVirusDetails_patients]
GO
