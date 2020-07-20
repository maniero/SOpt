<?php
class Pessoa {
    function __construct($nome, $sexo, $idade) {
        $this->nome = $nome;
        $this->sexo = $sexo;
        $this->idade = $idade;
    }
    function getNome() {
        return $this->nome;
    }
    public $nome;
    private $sexo;
    private $idade;
}
class Amigo extends Pessoa {
    function __construct($nome, $sexo, $idade, $diaDoAniversario) {
        parent::__construct($nome, $sexo, $idade);
        $this->diaDoAniversario = $diaDoAniversario;
    }
    private $diaDoAniversario;
}

$joao = new Amigo("Jonis", "masc", 20, 30);
echo "Nome: {$joao->nome}";
echo "Nome: " . $joao->getNome();

//https://pt.stackoverflow.com/q/296706/101
