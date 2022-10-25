<?php
class teste {
	public $nome = "João";
}
$retorno = array( 'nome' => 'João');
echo $retorno->nome;
echo "---\n";
echo $retorno['nome'];
echo "\n---\n";
$retorno = new teste();
echo $retorno->nome;
//echo $retorno['nome'];

//https://pt.stackoverflow.com/q/568329/101
