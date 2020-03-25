import java.util.List;
import java.util.ArrayList;

class Cachorro {
    private String Raca;
    private String cor;
    private String nome;
    private String nome_dono;
    private int idade;

    public Cachorro(String Raca,String cor,String nome,String nome_dono, int idade){
        this.Raca = Raca;
        this.cor = cor;
        this.nome =nome;
        this.nome_dono = nome_dono;
        this.idade = idade;
    }
    public String getRaca() {
        return Raca;
    }
    public void setRaca(String raca) {
        Raca = raca;
    }
    public String getCor() {
        return cor;
    }
    public void setCor(String cor) {
        this.cor = cor;
    }
    public String getNome() {
        return nome;
    }
    public void setNome(String nome) {
        this.nome = nome;
    }
    public String getNome_dono() {
        return nome_dono;
    }
    public void setNome_dono(String nome_dono) {
        this.nome_dono = nome_dono;
    }
    public int getIdade() {
        return idade;
    }
    public void setIdade(int idade) {
        this.idade = idade;
    }
    public  String toString(){
        return "Nome Cao:" + getNome() + "\nCor:" + getCor() +
                "\nRaca:" + getRaca()  +"\nNome dono:" + getNome_dono() + "\nIdade:" + getIdade();
    }
}

class Main {
    public static void main(String[] args) {
        List<Cachorro> dogs = new ArrayList<>();
        dogs.add(new Cachorro("rotweiller", "preto", "Flora", "Cesar", 8));
        for (Cachorro dog : dogs) System.out.println(dog);
    }
}

//https://pt.stackoverflow.com/q/170712/101
