CREATE TABLE sequencia_contrato (
    sequencial INT NOT NULL PRIMARY KEY,
    ano INT
);

CREATE TRIGGER numero_contrato BEFORE INSERT ON contrato
FOR each ROW
BEGIN
   SET NEW.contrato = PegaNumeroContrato();
END

CREATE FUNCTION PegaNumeroContrato() RETURNS VARCHAR(10)
BEGIN
    //precisa melhorar ainda, falta tratar o ano, por exemplo
    DECLARE ultimo_valor INT;
    SET ultimo_valor = (SELECT sequencial FROM sequencia_contrato);
    SET ultimo_valor = ultimo_valor + 1;
    UPDATE sequencia_contrato SET sequencial = ultimo_valor;
    SET @resultado = (SELECT concat(lpad(ultimo_valor, 5, '0'), '-', CAST((SELECT ano FROM sequencia_contrato) AS CHAR(4))));
    RETURN @resultado;
END

--https://pt.stackoverflow.com/q/52492/101
