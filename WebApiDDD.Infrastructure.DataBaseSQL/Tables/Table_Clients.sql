

/****** Object:  Table [dbo].[Clients]    Script Date: 6/10/2019 10:03:43 PM ******/


CREATE TABLE [dbo].[Clients](
	[Id] [varchar](36) IDENTITY(1,1) NOT NULL,
	[Name] [varchar](10) NULL,
	[LastName] [varchar](15) NULL,
	[email] [varchar](50) NULL,
	[CreatedAt] [datetime] NULL,
	[Active] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


