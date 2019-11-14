<?php

class Veiculos {
    protected $tipo = "carro";
}

class Veiculo extends Veiculos {
    public function tipo_veiculo() {
        if ($this->tipo == "carro") echo "Você selecionou carro. Escolha a cor.";
        elseif ($this->tipo == "moto") echo "Você selecionou moto. Escolha a cor.";
        else echo "Você não selecionou nenhum carro.";
    }
}
$carro = new Veiculo();
echo $carro->tipo_veiculo();

//https://pt.stackoverflow.com/q/106737/101
