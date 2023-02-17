import java.io.File;
import java.io.IOException;

class ExceptionTest02 {
    public static void main(String[] args) {
    	try {
            criarNovoArquivo();
            System.out.println("Criou arquivo");
    	} catch (IOException e) {
    		e.printStackTrace();
    	}
    }

    public static void criarNovoArquivo() throws IOException {
        File file = new File("arquivo\\teste.txt");
        file.createNewFile();
    }
}

//https://pt.stackoverflow.com/q/577323/101
