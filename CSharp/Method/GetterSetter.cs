class Cliente { //exemplo bem meia boa
    private string nome; //note que é privado
    public string getNome() => return nome; //aqui pega a variável interna e retorna
    public void setNome(string nome) => this.nome = nome; //aqui joga o parâmetro na variável da classe
    private decimal saldo;
    public decimal getSaldo() => return saldo - 100; //dá uma margem de erro
    public void setSaldo(decimal valor) => if (valor > 200) saldo = valor; //só aceita um mínimo de 200
}

//https://pt.stackoverflow.com/q/219409/101
