<?php
class Cliente {
    private $nome;
    public function __construct($nome) {
        $this->nome = $nome;
    }
	public function getNome() {
        return $this->nome;
    }
	public function __toString() {
	    return $this->nome;
	}
}

abstract class Animal {
    protected $nome;
    protected $dono;
    public function __construct($nome, $dono) {
       $this->nome = $nome;
       $this->dono = $dono;
   }
    public function getDono() {
        return $this->dono;
    }
}

class Cachorro extends Animal {
    public function __construct($nome, $dono) {
       parent::__construct($nome, $dono);
   }
}

$ana = new Cliente('ana');
$dog = new Cachorro('Rex', $ana);
echo "Dono: " . $dog->getDono();
echo "\nNome do dono: " . $dog->getDono()->getNome();

//https://pt.stackoverflow.com/q/45371/101
