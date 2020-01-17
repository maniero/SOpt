<?php
class ObjetoSimples {
   var $nome;
   var $cargo;
   var $turno;
   public static function construtor($nome, $cargo, $turno) {
	   	$obj = new ObjetoSimples();
    	$obj->nome = $nome;
     	$obj->cargo = $cargo;
    	$obj->turno = $turno;
    	return $obj;
   }
}

class ObjetoComposto {
    public static function construtor($nome, $setor, $nome2, $cargo, $turno) {
    	$obj = new ObjetoComposto();
    	$obj->nome = $nome;
    	$obj->setor = $setor;
    	$obj->equipe = new ObjetoSimples();
    	$obj->equipe->nome = $nome2;
    	$obj->equipe->cargo = $cargo;
    	$obj->equipe->turno = $turno;
    	return $obj;
    }
    public static function construtor2($nome, $setor, $obj2) {
    	$obj = new ObjetoComposto();
    	$obj->nome = $nome;
    	$obj->setor = $setor;
    	$obj->equipe = $obj2;
    	return $obj;
    }
    var $nome;
    var $setor;
    var $equipe;
}

$obj = new ObjetoSimples();
$obj->nome = "joao";
$obj->cargo = "gerente";
$obj->turno = "noite";
$obj2 = new ObjetoComposto();
$obj2->nome = "maria";
$obj2->setor = "fabrica";
$obj2->equipe = $obj;
$obj3 = ObjetoComposto::construtor("maria", "fabrica", "joao", "gerente", "noite");
$obj4 = ObjetoComposto::construtor2("maria", "fabrica", ObjetoSimples::construtor("joao", "gerente", "noite"));

//https://pt.stackoverflow.com/q/132257/101
