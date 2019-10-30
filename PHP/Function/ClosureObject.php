<?php
class Classe {
    public $exemplo = [];
    public function add($parametro1, $parametro2){
        $this->exemplo['parametro1'] = $parametro1;
        $this->exemplo['parametro2'] = $parametro2;
    }
}
$classe = new Classe;
$classe->add('parâmetro 1 aqui', function() { return 'retorno da função anonima para o parâmetro 2'; });
echo $classe->exemplo['parametro2']();

//https://pt.stackoverflow.com/q/99545/101
