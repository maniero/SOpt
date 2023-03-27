import java.util.*;

abstract class Cardapio {
    CafeDaManha cafeDaManha;
    Almoco almoco;
    Janta janta; 
}

class CafeDaManha extends Cardapio {}

class Almoco extends Cardapio {}

class Janta extends Cardapio {}

class SistemaRestaurante {
    private List<Cardapio> cardapios = new ArrayList<Cardapio>();
    public void cadastrarCardapio (Cardapio cardapio) {
        if(cardapio != null && !this.cardapios.contains(cardapio))
        cardapios.add(cardapio);
    }
}

class TesteRestaurante {
    public static void main(String[] args) {
        CafeDaManha cafeDaManha = new CafeDaManha();
        Almoco almoco = new Almoco();
        Janta janta = new Janta();
        SistemaRestaurante sistemaRestaurante = new SistemaRestaurante();
        sistemaRestaurante.cadastrarCardapio(almoco);
    }
}

//https://pt.stackoverflow.com/q/580366/101
