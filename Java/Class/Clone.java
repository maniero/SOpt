import java.util.*;
import java.lang.*;

class HelloWorld{
     public static void main(String []args) throws CloneNotSupportedException {
        ArrayList<Pessoa> listaDePessoas = new ArrayList<>();
        listaDePessoas.add(new Pessoa("Joao", 29));
        listaDePessoas.add(new Pessoa("Ana", 21));
        listaDePessoas.add(new Pessoa("Maria", 25));
        Pessoa pessoaAlterada = listaDePessoas.get(0).clone();
        listaDePessoas.get(0).setNome("Jao carlos");
        Pessoa pessoaRemovida = listaDePessoas.remove(2);
     }
}

class Pessoa implements Cloneable {    
    private String nome;
    public String getNome() { return nome; }
    public void setNome(String nome) { this.nome = nome; }
    private int idade;
    public int getIdade() { return idade; }
    public void setIdade(int idade) { this.idade = idade; }
    public Pessoa(String nome, int idade) {
        this.nome = nome;
        this.idade = idade;
    }
	public Pessoa clone() throws CloneNotSupportedException {
        return (Pessoa)super.clone();
    }
}

//https://pt.stackoverflow.com/q/160295/101
