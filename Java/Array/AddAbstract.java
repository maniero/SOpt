import java.util.ArrayList;
import java.util.Scanner;

class App {
    Scanner entrada = new Scanner(System.in);
    public static ArrayList<Cliente> clientes;
    public static void main(String[] args) {
        System.out.println("|||||Clínica Veterinária 1.0|||||\n\n");
        int opcao = 0;
        switch(opcao){
        case 1:
            String nome = null;
            String cpf = null;
            clientes.add(new Cliente(nome, cpf));
            break;
        case 2:
            String nomeCat = null; double pesoCat = 0.0; int idadeCat = 0;
            clientes.get(0).adicionaFelino(nomeCat, idadeCat, pesoCat);
            break;
        default:    
        	return;
        }
    }
}

abstract class Animal {
    protected double peso;
    public double calculaAnestesia(){
        double ml = 0.0;
        ml = peso*0.3;
        return ml;
    }
}

class Felino extends Animal {
    private String nome;
    private int idade;
    public Felino(String nome, int idade, double peso){
        this.nome = nome;
        this.peso = peso;
        this.idade = idade;

    }
    public String getNome() {
        return nome;
    }
    public void setNome(String nome) {
        this.nome = nome;
    }
    public int getIdade() {
        return idade;
    }
    public void setIdade(int idade) {
        this.idade = idade;
    }
    public double getPeso(){
        return peso;
    }
    public void setPeso(double peso){
        this.peso = peso;
    }
}

class Canino extends Animal{
    private String nome;
    private int idade;
    public Canino(String nome, int idade, double peso){
        this.peso = peso;
        this.nome = nome;
        this.idade = idade;

    }
    public String getNome() {
        return nome;
    }
    public void setNome(String nome) {
        this.nome = nome;
    }
    public int getIdade() {
        return idade;
    }
    public void setIdade(int idade) {
        this.idade = idade;
    }
    public double getPeso(){
        return peso;
    }
    public void setPeso(double peso){
        this.peso = peso;
    }
}

class Cliente {
    private String nome, cpf;
    private ArrayList<Animal> animais;
    public Cliente(String nome, String cpf){
        this.nome = nome;
        this.cpf = cpf;
    }
    public String getNome() {
        return nome;
    }
    public void setNome(String nome) {
        this.nome = nome;
    }
    public String getCpf() {
        return cpf;
    }
    public void setCpf(String cpf) {
        this.cpf = cpf;
    }
    public ArrayList<Felino> adicionaFelino(String nomeGato, int idade, double peso){
        animais.add(new Felino(nomeGato, idade, peso));
        return null;
    }
    public String adicionaCanino(String nomeCao, int idade, double peso){
        animais.add(new Canino(nomeCao, idade, peso));
        return("animal adicionado");
    }
}

//https://pt.stackoverflow.com/q/131991/101
