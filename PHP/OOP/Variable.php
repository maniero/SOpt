class Produto {
    private $preco; //variável de classe
    public function PrecoComDesconto($desconto) {
        //variável local - acessa variável de classe e parâmetro
        $valorDescontado = $this->preco * (1 + $desconto / 100);
        return $valorDescontado < 10 ? 10 : $valorDescontado; //o valor não pode ser < 10
    }
}

//https://pt.stackoverflow.com/q/156866/101
