import java.util.ArrayList;

public class Main {
    public static ArrayList<Filme> filme = new ArrayList<Filme>(11);
    public static ArrayList<Aula> aula = new ArrayList<Aula>(11);
    public static ArrayList<Classe> classe = new ArrayList<Classe>(11);
    public static Somador somador = new Somador();

    public static void main(String[] args) {
        System.out.println(somador.somar(filme));
        System.out.println(somador.somar(aula));
        System.out.println(somador.somar(classe));
    }
}

//https://pt.stackoverflow.com/q/472624/101
