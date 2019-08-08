CREATE TABLE TBPessoa (
    id integer,
    nome varchar(45),
    nascimento datetime,
    rg char(11),
    cpf char(11),
    sexo char(1),
    crm char(8),
    UNIQUE (crm)
);

--https://pt.stackoverflow.com/q/53183/101
