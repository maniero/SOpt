CREATE TABLE categoria (
    codigo SERIAL,
    nome VARCHAR(50) NOT NULL
);

INSERT INTO categoria (nome) values ('Lazer');
INSERT INTO categoria (nome) values ('Alimentação');
INSERT INTO categoria (nome) values ('Supermercado');
INSERT INTO categoria (nome) values ('Farmácia');
INSERT INTO categoria (nome) values ('Outros');

--https://pt.stackoverflow.com/q/256066/101
