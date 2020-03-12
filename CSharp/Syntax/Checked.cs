using System;
using static System.Console;
					
public class OverFlowTest {
    // Tamanho máximo de um int 
    static int maxIntValue = 2147483647;

    static int CheckedMethod() {
        int z = 0;
        try {
            // Vai estourar o limite e vai lanar exceção.
            z = checked(maxIntValue + 10);
        } catch (OverflowException e) {
            WriteLine("CHECKED lançou a exceção:  " + e.ToString());
        }
        // o z não teve seu valor reatribuido
        return z;
    }

    static int UncheckedMethod() {
        int z = 0;
        try {
            // Não vai gerar exceção 
            z = maxIntValue + 10;
        } catch (OverflowException e) {
			// isso não srá executado
            WriteLine("UNCHECKED lançou a exceção:  " + e.ToString());
        }
        // oi valor de zestará errado por causa do estouro: 2147483647 + 10 é o mesmo que -2147483639.
		// obviamente você esperava um valor positivo, mas ele vira e começa contar os 10 do menor número possível
		// se quiser entender mais veja http://pt.stackoverflow.com/q/47724/101
        return z;
    }

    public static void Main() {
        WriteLine($"CHECKED tem o valor: {CheckedMethod()}");
        WriteLine($"UNCHECKED tem o valor: {UncheckedMethod()}");
    }
}

//https://pt.stackoverflow.com/q/157342/101
