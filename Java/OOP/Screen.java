import java.util.*;

class Main {
    private static ArrayList<Tela> telas = new ArrayList<Tela>();
    public static void main (String[] args) {
        telas.add(new TelaConsulta());
        telas.add(new TelaReserva());
        for (String item : aplicarAcessos(new boolean[] { true, true })) System.out.println(item);
    }
    private static ArrayList<String> aplicarAcessos(boolean[] acessos) {
        ArrayList<String> abasAcervo = new ArrayList<>();
        for (int i = 0; i < acessos.length; i++) if (acessos[i]) abasAcervo.add(telas.get(i).constroi());
        return abasAcervo;
    }
}

interface Tela {
    String constroi();
}

class TelaConsulta implements Tela {
    public String constroi() {
        return "Tela Consulta";
    }
}
class TelaReserva implements Tela {
    public String constroi() {
        return "Tela Reserva";
    }
}

//https://pt.stackoverflow.com/q/287895/101
