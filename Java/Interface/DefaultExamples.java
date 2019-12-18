public class HelloWorld {
    public static void main(String args[]) {
        Veiculo veiculoT = new Veiculo();
        System.out.println("veiculoT");
        veiculoT.diagnostico();
        veiculoT.liga();
        Testador.teste(veiculoT);
        Financeiro.compra(veiculoT);
        System.out.println("---------------");
        Veiculo carro = new Carro();
        System.out.println("carro");
        carro.diagnostico();
        carro.liga();
        Testador.teste(carro);
        Financeiro.compra(carro);
        System.out.println("---------------");
        Carro carro2 = new Carro();
        System.out.println("carro2");
        carro2.diagnostico();
        carro2.liga();
        carro2.buzina();
        Testador.teste(carro2);
        Financeiro.compra(carro2);
    }
}

interface Funcionamento {
    default void liga() {
        System.out.println("Ligou!");
    }
    static void buzina() {
        System.out.println("Buzinou!");
    }
}

class Testador {
    public static void teste(Funcionamento veiculo) {
        System.out.println("Vai testar");
        veiculo.liga();
    }
}

class Financeiro {
    public static void compra(Veiculo veiculo) {
        System.out.println("Comprou N: " + veiculo.id);
        veiculo.diagnostico();
        veiculo.liga();
    }
}

class Veiculo implements Funcionamento {
    public int id = 1;
    public void diagnostico() {
        Funcionamento.super.liga();
        Funcionamento.buzina();
        liga();
        System.out.println("Tudo ok!");
    }
}

class Carro extends Veiculo {
    public void liga() {
        System.out.println("Vrom!");
    }
    public void buzina() {
        System.out.println("bi bi!");
    }
}

//https://pt.stackoverflow.com/q/121240/101
