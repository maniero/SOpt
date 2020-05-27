using System;

public class C {
    public static int Main() {
        var conta = new Conta();
        var txtValor = new Form();
        bool retorno;
 		if ((retorno = conta.Saca(Convert.ToDouble(txtValor.Text)))) {
            Console.WriteLine(retorno);
            return 1;
        }
        return 0;
     }
}

public class Conta {
    public bool Saca(double x) => true;
}

public class Form {
    public String Text;
}

//https://pt.stackoverflow.com/q/206902/101
