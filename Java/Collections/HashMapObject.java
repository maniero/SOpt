import java.util.*;

class Ideone {
	public static void main (String[] args) {
		Map<String, Alimento> mapalimentos = new HashMap<>();
	    mapalimentos.put("Maçã", new Alimento(50, 10));
	    mapalimentos.put("Melancia", new Alimento(30, 20));
	}
}

class Alimento {
    public Alimento(int calorias, int proteinas) {
        Calorias = calorias;
        Proteinas = proteinas;
    }
    int Calorias;
    int Proteinas;
}

//https://pt.stackoverflow.com/q/257120/101
