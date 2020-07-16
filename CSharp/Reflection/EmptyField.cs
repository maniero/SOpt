using System;

public class Program {
    public static void Main() {
        try {
            throw new CampoVazioException<int>(1);
        } catch (CampoVazioException<int>) {
            Console.WriteLine("deu erro");
        }
    }
}

public class CampoVazioException<T>: ApplicationException {
    public T Objeto { get; }

    public CampoVazioException(T objeto) : this(objeto, "") {}
    public CampoVazioException(T objeto, string mensagem) : base(mensagem) {
        Objeto = objeto;
    }
}

//https://pt.stackoverflow.com/q/288465/101
