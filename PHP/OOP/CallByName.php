<?php
class MinhaClasse {
    var $foo = 'ola mundo';
    var $bar = 'teste para o stack';
    public function index($fn = a) {
        echo $this->$fn(); // <-- é isso que eu quero
    }
    private function a() {
        return $this->foo;
    }
    private function b() {
        return $this->bar;
    }
}
$classe = new MinhaClasse();
$classe->index();
$classe->index(b);

//https://pt.stackoverflow.com/q/105037/101
