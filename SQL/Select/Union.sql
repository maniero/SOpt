create table tabela1 (
  id int(6) primary key auto_increment,
  nome varchar(10) not null,
  salario decimal);
  
create table tabela2 (
  id int(6) primary key auto_increment,
  nome varchar(10) not null,
  salario decimal);
  
insert into tabela1 (nome, salario) values
  ("joão", 100.00),
  ("josé", 120.00),
  ("maria", 200.00),
  ("joão", 150.00);
  
insert into tabela2 (nome, salario) values
  ("joão", 100.00),
  ("josé", 120.00),
  ("manuel", 200.00),
  ("joão", 150.00);

select * from tabela1 where salario > 100.00
union
select * from tabela2;

select * from tabela1 where salario > 100.00
union all
select * from tabela2;

select * from tabela1 where salario > 100.00
union
select * from tabela2;

--https://pt.stackoverflow.com/q/153496/101
