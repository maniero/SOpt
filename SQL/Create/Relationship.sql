CREATE TABLE Fornecedor {
  id INT(4) NOT NULL UNSIGNED AUTO_INCREMENT,
  nome VARCHAR(100) NOT NULL,
  endereco INT(4) NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (endereco) REFERENCES Endereco(idEndereco)
}

CREATE TABLE Funcionario {
  id INT(4) NOT NULL UNSIGNED AUTO_INCREMENT,
  nome VARCHAR(100) NOT NULL,
  endereco INT(4) NOT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY (endereco) REFERENCES Endereco(idEndereco)
}

CREATE TABLE Endereco {
  idEndereco INT(4) NOT NULL UNSIGNED AUTO_INCREMENT,
  logradouro VARCHAR(100) NOT NULL,
  cidade VARCHAR(100) NOT NULL,
  estado CHAR(02) NOT NULL,
  cep VARCHAR(8) NOT NULL.
  PRIMARY KEY(idEndereco)
}

--https://pt.stackoverflow.com/q/52878/101
