using static System.Console;
using System;

public class Program {
	public static void Main() {
		ContaPoupanca poupanca = new ContaPoupanca();
	    poupanca.CalculaInvestimento();
    	Conta conta = new ContaPoupanca();
    	conta.CalculaInvestimento();
	}
}

public class Conta {
	public virtual void CalculaInvestimento() { throw new NotImplementedException(); }
}
public class ContaPoupanca : Conta {
	public override void CalculaInvestimento() { WriteLine("ok"); }
}

//https://pt.stackoverflow.com/q/209082/101
