import java.util.Scanner;

class Ideone {
	public static void main(String[] args) {
		Scanner on = new Scanner(System.in); 
		System.out.println("Digite a palavra: ");
		String texto = on.nextLine();
		int soma = 0;
		for (char caractere : texto.toCharArray()) {
            //"A" vale 97, então tira 96 e assim por diante
  			soma += caractere > 96 && caractere < 123 ? caractere - 96 : 0;
		}
		System.out.println(soma);    
    }  
}

//https://pt.stackoverflow.com/q/152456/101
