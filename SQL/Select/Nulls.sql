CREATE TABLE [dbo].[Exemplo](
	[cod] [int] NOT NULL,
	[texto] [char](1) NULL,
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

insert Exemplo(cod,texto)values(1,'S');
insert Exemplo(cod,texto)values(2,'N');
insert Exemplo(cod)values(3);

select * from Exemplo;
select * from Exemplo where texto <> 'N' OR texto is null

--https://pt.stackoverflow.com/q/87514/101
