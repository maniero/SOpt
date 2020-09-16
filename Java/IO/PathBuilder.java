import java.io.*;

class Main {
	public static void main (String[] args) {
    	File path = new File("src", "models");
		System.out.println(path.getPath());
		System.out.println(path.getAbsolutePath());
		File novoPath = new File(".", path.getPath());
		System.out.println(novoPath.getPath());
		System.out.println(novoPath.getAbsolutePath());
	}
}

//https://pt.stackoverflow.com/q/45336/101
