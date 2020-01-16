import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
 
class Main {
	public static void main (String[] args) {
		char mat[][] = new char[5][5];
		List<Integer> random = randomNumbers(65, 90, 25);
		int posicao  = 0;
        for (int ctlin = 0; ctlin < 5; ctlin++)
            for (int ctcol = 0; ctcol < 5; ctcol++) mat[ctlin][ctcol] = (char)(int)random.get(posicao++);
        for (int ctlin = 0; ctlin < 5; ctlin++) {
            for (int ctcol = 0; ctcol < 5; ctcol++) System.out.print(mat[ctlin][ctcol] + " ");
            System.out.println();
        }       
	}
    public static List<Integer> randomNumbers(int start, int end, int count) {
		List<Integer> lista = new ArrayList<>(end - start + 1);
		for (int i = start; i <= end; i++) lista.add(i);
		Collections.shuffle(lista);
		lista = lista.subList(0, count);
		return lista;
    }
}

//https://pt.stackoverflow.com/q/131079/101
