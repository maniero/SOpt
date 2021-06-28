create table planos(
    codkey (primary),
    nome_plano varchar(80)
)

create table planos_parcelas(
    codkey (primary),
    item int (primary),
    valor decimal(12, 2)
)

--https://pt.stackoverflow.com/q/515614/101
