import java.io.*;

class Program {
	public static void main (String[] args) throws java.lang.Exception {
		System.out.println(lerInt());
	}
	public static int lerInt() {
		BufferedReader input = new BufferedReader(new InputStreamReader(System.in));
        while (true) {
		    try {
		        return Integer.parseInt(input.readLine());
		    } catch (IOException e) {
		        System.out.println("Falha critica.");
		    } catch (NumberFormatException e) {
		        System.out.println("Você digitou uma entrada invalida.");
		    }
	    }
    }
}

//https://pt.stackoverflow.com/q/43083/101
