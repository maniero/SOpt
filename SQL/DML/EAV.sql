CREATE TABLE TABELA (
    TABELA INT NOT NULL,
    COLUNA INT NOT NULL,
    LINHA INT NOT NULL,
    VALOR VARCHAR,
    PRIMARY KEY (TABELA, COLUNA, LINHA));

CREATE TABLE PESSOA (
    ID INT NOT NULL PRIMARY KEY,
    NOME VARCHAR(60),
    NASCTO DATE,
    SALARIO MONEY);

CREATE TABLE DIVIDA (
    ID INT NOT NULL PRIMARY KEY,
    CLIENTE INT,
    VENCTO DATE,
    VALOR MONEY);

INSERT INTO TABELA (TABELA, COLUNA, LINHA, VALOR) VALUES
                   (1, 1, 1, "JOÃO"), //nome da pessoa linha 1
                   (1, 2, 1, "15/07/1980"), //nascto
                   (1, 3, 1, "2000,00"), //salario
                   (1, 1, 2, "JOSÉ"), //linha 2 da pessoa
                   (1, 2, 2, "28/10/1986"),
                   (1, 3, 2, "1500,00"),
                   (2, 1, 1, "1"), //tabela divida, relaciona pessoa 1
                   (2, 2, 1, "20/08/2016"), //vencto
                   (2, 3, 1, "100,00"); //valor
                   
//https://pt.stackoverflow.com/q/138621/101
