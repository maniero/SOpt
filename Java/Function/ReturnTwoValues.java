class Resultado {
    public boolean flag; //não faça isto, fiz só para simplificar
    public Resultado(boolean flag) {
        this.flag = flag;
    }
}

public class HelloWorld {
    public Resultado getProdutosWS(Resultado resultado) {
        try {
            listProdutos[] produtos = ws.getProdutos(prod);
            resultado.flag = true;
            return produtos;
        } catch(RemoteException ex) {
            resultado.flag = false;
            return null;
        }
    }
    
    public static int main(String []args) {
        Resultado resultado;
        listProdutos[] lista = getProdutosWS(resultado);
        if (resultado) System.out.println(lista[0]); //isto é só um exemplo de uso, nada que seja útil
    }
}

//https://pt.stackoverflow.com/q/39309/101
