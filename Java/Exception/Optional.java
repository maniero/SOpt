import java.util.*;

class Conta {
	public double saldo;
}

class ContaCorrente extends Conta {
    public void deposita(double valor) {
        super.saldo += (valor);
    }
    public Optional<Double> saca(double valor) {
        if (super.saldo < valor) return Optional.empty();
        super.saldo += (valor - 0.10);
        return Optional.of(valor);
    }
}

public class Main {
    public static void main(String[] args) {
        ContaCorrente conta = new ContaCorrente();
        conta.deposita(200);
        var sacado = conta.saca(300);
        if (sacado.isEmpty()) System.out.println("O saldo nao eh suficiente para saque");
        else System.out.println("A operação foi concluída e foi sacado " + sacado.get());
    }
}

//https://pt.stackoverflow.com/q/483290/101
