<?php
class Conexao {
    private static $conexao = "dados da conexao aqui - classe";
    public static function PegaConexao() {
   		return self::$conexao;
    }
}

function conexao(){
    static $conexao = "dados da conexao aqui - funcao";
    return $conexao;
}

class Uso {
	public function AbreBanco1() {
		echo conexao() . "\n";
	}
	public function AbreBanco2() {
		echo Conexao::PegaConexao();
	}
}

Uso::AbreBanco1();
Uso::AbreBanco2();

//https://pt.stackoverflow.com/q/53794/101
