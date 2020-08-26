List<Integer> lista = new List<Integer>();

public static void generateStringArray(int entrada) {
    if (entrada < lista.length()) return;
    for (int i = 0; i < entrada; i++) {
       System.out.println(lista.get(i));
    }
}

//https://pt.stackoverflow.com/q/360913/101
