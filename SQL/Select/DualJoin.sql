--Cria tabelas
create table Banco(
	Codigo	numeric(4,0) not null identity (1,1) ,
	Nome	varchar(40),
	Num_Sac numeric(12),
	Cnpj	numeric(14)
);


create table Agencia(
	Codigo		numeric(4,0) not null identity(1,1),
	Nome		varchar(40) not--Cria tabelas
create table Banco(
	Codigo	numeric(4,0) not null identity (1,1) ,
	Nome	varchar(40),
	Num_Sac numeric(12),
	Cnpj	numeric(14)
);


create table Agencia(
	Codigo		numeric(4,0) not null identity(1,1),
	Nome		varchar(40) not null,
	Rua			varchar(45),
	Bairro		varchar(30),
	Cidade		varchar(30),
	Telefone	numeric(12),
	Cod_Banco	numeric(4) not null
);

create table Conta (
	Codigo		numeric(4) not null identity(1,1),
	Tipo_Conta	varchar(10) not null,
	Saldo		numeric(9,2) not null,
	Cod_Titular	numeric(4) not null,
	Cod_Ag		numeric(4) not null
);

create table Cliente (
	Codigo		numeric(4) not null identity(1,1),
	Nome		varchar(60) not null,
	Rua			varchar(45) ,
	Bairro		varchar(30) ,
	Cidade		varchar(30) not null,
	Telefone	numeric(12) null,
	Razao_Social varchar(100) null,
	Tipo_Pessoa	varchar(1) not null,
	Cpf_Cnpj	numeric(14) not null
);

create table Titulares_Adicionais(
	Cod_Cli			numeric(4) not null,
	Cod_Conta		numeric(4) not null,
	Grau_Parentesco	varchar(10) null,
	Data_Nasc		date null,
	Limite			numeric(9,2) not null
);

--Altera tabelas

--Chaves primárias
--Adiciona chave primária banco
alter table Banco
add constraint PK_Banco
primary key(codigo)

--Adiciona chave primária Cliente
alter table Cliente
add constraint PK_Cliente
primary key(codigo)

--Adiciona chave primária agencia
alter table agencia
add constraint PK_Codigo_Ag
primary key(codigo)

--Adiciona chave primária Conta
alter table Conta
add constraint PK_Conta
primary key(codigo)


--Chaves Estrangeiras
--Adiciona chaves estrangeiras da Conta
alter table Conta
add constraint FK_Cod_Titular_Conta
foreign key(cod_titular)
references Cliente(codigo);

alter table Conta
add constraint FK_Cod_Ag
foreign key(cod_ag)
references agencia(codigo);

--Adiciona chave estrangeira Titulares Adicionais
alter table Titulares_Adicionais
add constraint FK_Cod_Cli_Titulares
foreign key(cod_cli)
references cliente(codigo)

alter table Titulares_Adicionais
add constraint FK_Cod_Conta_Titulares
foreign key(Cod_Conta)
references conta(codigo)

--Adiciona chave estrangeira Agencia
alter table agencia
add constraint FK_Cod_Banco
foreign key (Cod_Banco)
references banco(codigo)



insert into banco(Nome,Num_sac)
values ('Banco do Brasil', 08007290001)



insert into agencia(Nome,Rua,Bairro,Cidade,Telefone,Cod_Banco)
values('CentroFranca','General Osório, 1930', 'Centro','Franca',37210001,1)



insert into agencia(Nome,Rua,Bairro,Cidade,Telefone,Cod_Banco)
values('Estacao','Padre Contado, 430', 'Estação','Franca',37231441,1)


insert into agencia(Nome,Rua,Bairro,Cidade,Telefone,Cod_Banco)
values('Fonte-Luminosa','Padre Duarte, 234', 'Centro','Araraquara',34031421,1)


insert into cliente (Nome,Rua, bairro,Cidade,Telefone,Tipo_Pessoa, Razao_Social,Cpf_Cnpj)
values('Marquito Marques', 'Rua da Paz', 'Centro', 'Franca',37211223, 'f',NULL,12345678911)

insert into cliente (Nome,Rua, bairro,Cidade,Telefone,Tipo_Pessoa, Razao_Social,Cpf_Cnpj)
values('Ezequiel Barbosa dos Santos', 'Rua Ouvidor Freire , 1567', 'Centro', 'Franca',991240270, 'f',NULL,43344452843)

insert into cliente (Nome,Rua, bairro,Cidade,Telefone,Tipo_Pessoa, Razao_Social,Cpf_Cnpj)
values('EZX Tecnologia',  'Rua Ouvidor Freire , 1567', 'Centro', 'Franca',991240270, 'j',
'Ezequiel Barbosa dos Santos Tecnologia',24355512343214)


insert into cliente (Nome,Rua, bairro,Cidade,Telefone,Tipo_Pessoa, Razao_Social,Cpf_Cnpj)
values('Espetinho do Jacaré', 'Rua Anor Ribeiro de Souza, 1325', 'João Mendes', 'Ribeirão Corrente',991436617, 'j',
'Ezequiel Barbosa dos Santos Alimentos e Bebidas',24355512345323)

insert into conta(Tipo_Conta,saldo,Cod_Titular,Cod_Ag)
values ('poupanca',4000, 1, 1)

insert into conta(Tipo_Conta,saldo,Cod_Titular,Cod_Ag)
values ('salario',23000, 2, 3)

insert into conta(Tipo_Conta,saldo,Cod_Titular,Cod_Ag)
values ('corrente',35000, 3, 2)

insert into conta(Tipo_Conta,saldo,Cod_Titular,Cod_Ag)
values ('corrente',459300, 4, 3)


insert into cliente (Nome,Rua, bairro,Cidade,Telefone,Tipo_Pessoa, Razao_Social,Cpf_Cnpj)
values('Lara Gabrielle Barbosa', 'Rua Ouvidor Freire , 1567', 'Centro', 'Franca',991240270, 'f',Null,12345678911)

insert into cliente (Nome,Rua, bairro,Cidade,Telefone,Tipo_Pessoa, Razao_Social,Cpf_Cnpj)
values('Karen Gabrielle Barbosa', 'Rua Ouvidor Freire , 1567', 'Centro', 'Franca',991240270, 'f',
Null,12345678941)



insert into Titulares_Adicionais(Cod_Cli, Cod_Conta, Grau_Parentesco, limite)
values (5, 2, 'Conjuge', 1200);


insert into Titulares_Adicionais(Cod_Cli, Cod_Conta, Grau_Parentesco, limite)
values (6, 2, 'Filha', 350); null,
	Rua			varchar(45),
	Bairro		varchar(30),
	Cidade		varchar(30),
	Telefone	numeric(12),
	Cod_Banco	numeric(4) not null
);

create table Conta (
	Codigo		numeric(4) not null identity(1,1),
	Tipo_Conta	varchar(10) not null,
	Saldo		numeric(9,2) not null,
	Cod_Titular	numeric(4) not null,
	Cod_Ag		numeric(4) not null
);

create table Cliente (
	Codigo		numeric(4) not null identity(1,1),
	Nome		varchar(60) not null,
	Rua			varchar(45) ,
	Bairro		varchar(30) ,
	Cidade		varchar(30) not null,
	Telefone	numeric(12) null,
	Razao_Social varchar(100) null,
	Tipo_Pessoa	varchar(1) not null,
	Cpf_Cnpj	numeric(14) not null
);

create table Titulares_Adicionais(
	Cod_Cli			numeric(4) not null,
	Cod_Conta		numeric(4) not null,
	Grau_Parentesco	varchar(10) null,
	Data_Nasc		date null,
	Limite			numeric(9,2) not null
);

--Altera tabelas

--Chaves primárias
--Adiciona chave primária banco
alter table Banco
add constraint PK_Banco
primary key(codigo)

--Adiciona chave primária Cliente
alter table Cliente
add constraint PK_Cliente
primary key(codigo)

--Adiciona chave primária agencia
alter table agencia
add constraint PK_Codigo_Ag
primary key(codigo)

--Adiciona chave primária Conta
alter table Conta
add constraint PK_Conta
primary key(codigo)


--Chaves Estrangeiras
--Adiciona chaves estrangeiras da Conta
alter table Conta
add constraint FK_Cod_Titular_Conta
foreign key(cod_titular)
references Cliente(codigo);

alter table Conta
add constraint FK_Cod_Ag
foreign key(cod_ag)
references agencia(codigo);

--Adiciona chave estrangeira Titulares Adicionais
alter table Titulares_Adicionais
add constraint FK_Cod_Cli_Titulares
foreign key(cod_cli)
references cliente(codigo)

alter table Titulares_Adicionais
add constraint FK_Cod_Conta_Titulares
foreign key(Cod_Conta)
references conta(codigo)

--Adiciona chave estrangeira Agencia
alter table agencia
add constraint FK_Cod_Banco
foreign key (Cod_Banco)
references banco(codigo)



insert into banco(Nome,Num_sac)
values ('Banco do Brasil', 08007290001)



insert into agencia(Nome,Rua,Bairro,Cidade,Telefone,Cod_Banco)
values('CentroFranca','General Osório, 1930', 'Centro','Franca',37210001,1)



insert into agencia(Nome,Rua,Bairro,Cidade,Telefone,Cod_Banco)
values('Estacao','Padre Contado, 430', 'Estação','Franca',37231441,1)


insert into agencia(Nome,Rua,Bairro,Cidade,Telefone,Cod_Banco)
values('Fonte-Luminosa','Padre Duarte, 234', 'Centro','Araraquara',34031421,1)


insert into cliente (Nome,Rua, bairro,Cidade,Telefone,Tipo_Pessoa, Razao_Social,Cpf_Cnpj)
values('Marquito Marques', 'Rua da Paz', 'Centro', 'Franca',37211223, 'f',NULL,12345678911)

insert into cliente (Nome,Rua, bairro,Cidade,Telefone,Tipo_Pessoa, Razao_Social,Cpf_Cnpj)
values('Ezequiel Barbosa dos Santos', 'Rua Ouvidor Freire , 1567', 'Centro', 'Franca',991240270, 'f',NULL,43344452843)

insert into cliente (Nome,Rua, bairro,Cidade,Telefone,Tipo_Pessoa, Razao_Social,Cpf_Cnpj)
values('EZX Tecnologia',  'Rua Ouvidor Freire , 1567', 'Centro', 'Franca',991240270, 'j',
'Ezequiel Barbosa dos Santos Tecnologia',24355512343214)


insert into cliente (Nome,Rua, bairro,Cidade,Telefone,Tipo_Pessoa, Razao_Social,Cpf_Cnpj)
values('Espetinho do Jacaré', 'Rua Anor Ribeiro de Souza, 1325', 'João Mendes', 'Ribeirão Corrente',991436617, 'j',
'Ezequiel Barbosa dos Santos Alimentos e Bebidas',24355512345323)

insert into conta(Tipo_Conta,saldo,Cod_Titular,Cod_Ag)
values ('poupanca',4000, 1, 1)

insert into conta(Tipo_Conta,saldo,Cod_Titular,Cod_Ag)
values ('salario',23000, 2, 3)

insert into conta(Tipo_Conta,saldo,Cod_Titular,Cod_Ag)
values ('corrente',35000, 3, 2)

insert into conta(Tipo_Conta,saldo,Cod_Titular,Cod_Ag)
values ('corrente',459300, 4, 3)


insert into cliente (Nome,Rua, bairro,Cidade,Telefone,Tipo_Pessoa, Razao_Social,Cpf_Cnpj)
values('Lara Gabrielle Barbosa', 'Rua Ouvidor Freire , 1567', 'Centro', 'Franca',991240270, 'f',Null,12345678911)

insert into cliente (Nome,Rua, bairro,Cidade,Telefone,Tipo_Pessoa, Razao_Social,Cpf_Cnpj)
values('Karen Gabrielle Barbosa', 'Rua Ouvidor Freire , 1567', 'Centro', 'Franca',991240270, 'f',
Null,12345678941)



insert into Titulares_Adicionais(Cod_Cli, Cod_Conta, Grau_Parentesco, limite)
values (5, 2, 'Conjuge', 1200);


insert into Titulares_Adicionais(Cod_Cli, Cod_Conta, Grau_Parentesco, limite)
values (6, 2, 'Filha', 350);

SELECT Titulares_Adicionais.Limite, Titulares_Adicionais.Grau_Parentesco,
    Conta.Cod_Titular, Cliente.Nome
FROM Titulares_Adicionais
INNER JOIN Conta ON Titulares_Adicionais.Cod_Conta = Conta.Codigo
INNER JOIN Cliente ON Titulares_Adicionais.Cod_Cli = Cliente.Codigo
WHERE Titulares_Adicionais.Cod_Cli = 5;

--https://pt.stackoverflow.com/q/85526/101
