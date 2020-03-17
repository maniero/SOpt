import java.util.Scanner;

class NumerosRomanos {
    public static void main (String args[]) {
        System.out.println ("Digite um Número em Romanos, para saber qual é esse Número em Decimais");
        Scanner sc = new Scanner (System.in);
        String numeroRomanoInicial = sc.nextLine();
        String numeroRomano = numeroRomanoInicial.toUpperCase();
	    System.out.println(verificarNumerosRomanos(numeroRomano));
    }

    public static int verificarNumerosRomanos(String numeroRomano) {
        int digitoRomano = 0;
        int digitoRomanoemconjunto = 0;
        for (int i = 0; i < numeroRomano.length(); i++) {
	        digitoRomano = numeroRomano.charAt(i);    
            switch (digitoRomano) {
                case 'I': digitoRomano += 1;
            break;
                case 'V': digitoRomano += 5;
            break;
                case 'X': digitoRomano += 10;
            break;
                case 'L': digitoRomano += 50;
            break;
                case 'C': digitoRomano += 100;
            break;
                case 'D': digitoRomano += 500;
            break;
                case 'M': digitoRomano += 1000;
            break;
            default: System.out.println("Dígito Romano Errado.");
            }
        }
        int soma = 0;
        for (int i = 0; i < numeroRomano.length(); i++) {
	        char dr = numeroRomano.charAt(i);
	        char drSeguinte = i < numeroRomano.length() - 1 ? numeroRomano.charAt(i + 1) : ' ';
            if (dr == 'I' && drSeguinte == 'V') {
                digitoRomanoemconjunto += 4;
            } else if (dr == 'I' && drSeguinte == 'X') {
                digitoRomanoemconjunto += 9;
            } else if (dr == 'X' && drSeguinte == 'L') {
                digitoRomanoemconjunto += 50;
            } else if (dr == 'X' && drSeguinte == 'C') {
                digitoRomanoemconjunto += 90;
            } else if (dr == 'C' && drSeguinte == 'D') {
                digitoRomanoemconjunto += 400;
            } else if (dr == 'C' && drSeguinte == 'M') {
               digitoRomanoemconjunto += 900;
            }
        }
        soma += digitoRomano + digitoRomanoemconjunto;
        return soma;
    }
}

//https://pt.stackoverflow.com/q/160022/101
