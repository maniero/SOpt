public class Main {
	public static void main(String[] args) {
		System.out.println(teste());
	}
	
	public static boolean teste() {
		try {
            System.out.println("Parte 1");
            return false;
        } finally {
            System.out.println("Parte 2");
        }
	}
}

//https://pt.stackoverflow.com/q/42313/101
