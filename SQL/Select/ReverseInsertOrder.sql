create table tabela (id int not null auto_increment,
                     nome varchar(60),
                     idade int,
                     primary key (id)
                    );
insert into tabela (nome, idade) values ("Pedro", 20);
insert into tabela (nome, idade) values ("João", 21);

SELECT * FROM tabela ORDER BY id DESC;

--https://pt.stackoverflow.com/q/339396/101
