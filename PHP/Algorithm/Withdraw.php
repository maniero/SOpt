public function sacar(){
    if ($this->statusConta) {
        echo 'A conta está fechada!';
        return;
    }
    if ($this->saldoConta - 50 < 0) {
        echo'Você não pode sacar mais do que ' . $this->$saldoConta;
        return;
    }
    $this.saldoConta -= 50;
}

//https://pt.stackoverflow.com/q/212652/101
