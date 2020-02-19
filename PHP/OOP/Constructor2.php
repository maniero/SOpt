<?php 

class Users {
	public $name; 
	public $idade;
	public $email;
	private $senha;
	function __construct($name, $idade, $email, $senha){ 
	    $this->name = $name;
	    $this->idade = $idade;
	    $this->email = $email;
	    $this->setPassword($senha);
	    echo "O objeto foi contruido!";
	}
	function setPassword($senha) {
	    if (strlen($senha) > 8 and strlen($senha) < 13) {
	        $this->senha = password_hash($senha, PASSWORD_DEFAULT);
	    } else {
	        die ('Sua senha deve conter entre 8 e 13 caracters');
	    }
	}
}
$pessoa = new Users("Flavio", 19, "flvdeveloper@gmail.com", "testando123");
var_dump($pessoa);
$pessoa->setPassword("testando123");
var_dump($pessoa);

//https://pt.stackoverflow.com/q/150069/101
