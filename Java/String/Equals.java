import java.util.Scanner;

class VerificaLetra {
	public static void main(String[] args) {
	    System.out.print("Informe o sexo. F para feminino e M para Masculino: ");
	    Scanner scan = new Scanner(System.in);
	    String letra = scan.nextLine();
	    String sexo = " ";
	    if (letra.equals("f") || letra.equals("F")) {
	        sexo = "Sexo = Feminino";
	    } else if (letra.equals("m") || letra.equals("f")) {
	        sexo = "Sexo = Masculino";
	    }
	    System.out.println(sexo);        
    }
}

//http://pt.stackoverflow.com/q/187034/101
