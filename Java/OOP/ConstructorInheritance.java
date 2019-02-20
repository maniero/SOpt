public class Pessoa {
    protected String nome;
    protected Date nascimento;

    public Pessoa(String nome, Date nascimento){
        this.nome = nome;
        this.nascimento = nascimento;
    }
}

public class Cliente extends Pessoa{
    protected String endereco;
    protected int codigo;

    public Cliente(int codigo String nome, String endereco, Date nascimento) {
        super(nome, nascimento);
        this.endereco = endereco;
        this.codigo = codigo;
    }
}

//https://pt.stackoverflow.com/q/45699/101
