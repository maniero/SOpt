package iniciativa13ªera;

public class HelloWorld {
    public static void main(String[] args) {
        Jogador giovane = new Jogador();
        giovane.setNomeJogador("Giovane - Ekth");
        giovane.setModDestreza(3);
        giovane.setModTamanho(0);
//        giovane.calcular();  //não tem este método
    }   
}

class Jogador {
    //Atributos
    String nomeJogador;
    int modTamanho;
    int modDestreza;
    public void nome (String nome){
        this.setNomeJogador(nome);
    }
    public void tamanho(int valor){
        this.setModTamanho(valor);
    }
    public void destreza(int valor){
        this.setModDestreza(valor);
    }
    public String getNomeJogador() {
        return nomeJogador;
    }
    public void setNomeJogador(String nomeJogador) {
        this.nomeJogador = nomeJogador;
    }
    public int getModTamanho() {
        return modTamanho;
    }
    public void setModTamanho(int modTamanho) {
        this.modTamanho = modTamanho;
    }
    public int getModDestreza() {
        return modDestreza;
    }
    public void setModDestreza(int modDestreza) {
        this.modDestreza = modDestreza;
    }
    public Jogador() {
        this.setModTamanho(0);
        this.setModDestreza(0);
    }
}

//https://pt.stackoverflow.com/q/246632/101
