import java.util.*;

class Main {
    public static void main(String []args) {
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();
		try {
  		    System.out.println(primo(n) ? "Verdadeiro" : "Falso");
		} catch (Exception ex) {
			System.out.println(ex.getMessage());
		}
	}
	public static boolean primo(int n) throws Exception {
		if (n <= 0) throw new Exception("Número não pode ser menor ou igual à zero!");
	  	int contador = 0;
	  	for (int j = 1; j <= Math.sqrt(n); j++){
	  		if (n % j == 0) {
	  			contador++;
	  			if (contador == 2) return false;
	  		}
	  	}
	  	return true;
	}
}

//https://pt.stackoverflow.com/q/148017/101
