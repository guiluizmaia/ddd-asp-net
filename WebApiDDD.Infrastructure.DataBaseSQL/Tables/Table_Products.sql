

/****** Object:  Table [dbo].[Product]    Script Date: 6/10/2019 10:07:14 PM ******/


CREATE TABLE [dbo].[Product](
	[Id] [varchar](36) IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Value] [decimal](18, 2) NULL,
	[Active] [bit] NULL,
	[ClientId] [varchar](36) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([ClientId])
REFERENCES [dbo].[Clients] ([Id])
GO


