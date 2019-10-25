import java.io.*;

public class Teste {
    public static void main(String[] args) {        
        try {
            String diretorio = System.getProperty("user.dir");      
            File arquivo = new File(diretorio, "ip.txt");  
            FileOutputStream fos = new FileOutputStream(arquivo);  
            String texto = "192.168.1.1";  
            fos.write(texto.getBytes());  
            fos.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}

//https://pt.stackoverflow.com/q/97799/101
