CREATE UNIQUE INDEX IpEmail ON tabela (ip ASC, email ASC)

ALTER TABLE tabela ADD CONSTRAINT IpEmail PRIMARY KEY CLUSTERED (ip, email);

--https://pt.stackoverflow.com/q/246940/101
