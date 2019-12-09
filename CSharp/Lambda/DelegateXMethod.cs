using static System.Console;
using System;

class Exemplo {
    public Func<bool> VerificaAlgo { get; set; }
    public void FazAlgo() {
        if (VerificaAlgo()) WriteLine("é apenas um teste");
        else WriteLine("a coisa é séria");
    }
}

class Program {
    public void Main() {
        Exemplo teste = new Exemplo();
        teste.VerificaAlgo = new Func<bool>(() => Console.ReadLine() == "teste");
        teste.FazAlgo();
    }
}

//https://pt.stackoverflow.com/q/116095/101
