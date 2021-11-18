public class Exemplo {
    private static List<int> lista = new List<int>();
    public static TrocaLista() {
        lista = new List<int>(); //o objeto anterior ficará sem referência
    }
}

//https://pt.stackoverflow.com/q/203590/101
