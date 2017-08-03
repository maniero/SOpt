public class Exemplo<T> {
    private List<T> listinhaGlobal;
    private T instanciaDeExemplo;
    private T GetInformation() {
        foreach(var item in listinhaGlobal) {
            if (item.exEnum == instanciaDeExemplo.exEnum)) {
                return item;
            }
        }
        return null;
    }
}

//https://pt.stackoverflow.com/q/225972/101
