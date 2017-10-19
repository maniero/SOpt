<?php
class Pessoa {     
	private $nome;
	private $idade;
	private $sexo;  
	public function __construct($stringNome, $stringIdade, $stringSexo) {
		$this->nome  = $stringNome;
		$this->idade = $stringIdade;
		$this->sexo  = $stringSexo; 
	}  
} 

class Funcionario extends Pessoa { 
	private $empresa;
	private $salario;
	public function __construct($stringNome, $stringIdade, $stringSexo, $stringEmpresa, $stringSalario) {
		parent::__construct($stringNome, $stringIdade, $stringSexo);
		$this->empresa = $stringEmpresa;
		$this->salario = $stringSalario;     
	}
}

$vendedor = new Funcionario("Yuri", "19", "Masculino", "Tam", "3000");
?>

//https://pt.stackoverflow.com/q/247363/101
