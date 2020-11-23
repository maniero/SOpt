import java.util.*;

class Conta {
	public double saldo;
}

class ContaCorrente extends Conta {
    public void deposita(double valor) {
        super.saldo += (valor);
    }
    public boolean saca(double valor) {
        if (super.saldo < valor) return false;
        super.saldo += (valor - 0.10);
        return true;
    }
}

public class Main {
    public static void main(String[] args) {
        ContaCorrente conta = new ContaCorrente();
        conta.deposita(200);
        if (!conta.saca(300)) System.out.println("O saldo nao eh suficiente para saque");
    }
}

//https://pt.stackoverflow.com/q/483290/101
