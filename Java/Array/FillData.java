public class Program {
	public static void main(String[] args) {
		Numeros objeto = new Numeros();
		objeto.gerador();
		for (int item : objeto.getDezenas()) System.out.println(item);
	}
}

class Numeros {
    private int[] numeros = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    private int[] dezenas = new int[100];
    public int[] getDezenas() {
        return this.dezenas;
   }
   public void gerador() {
        for (int i = 0; i < numeros.length; i++) {
            for (int j = 0; j < numeros.length; j++) dezenas[i * 10 + j] = i * 10 + j;
        }
   	}
}

//https://pt.stackoverflow.com/q/360380/101
