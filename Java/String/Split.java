class Main {
	public static void main (String[] args) {
		System.out.println("Dan Lucio Prada".split(" ")[2]);
		
		//forma correta
		String nome = "Dan Lucio Prada";
		String[] partes = nome.split(" ");
		System.out.println(partes[partes.length - 1]);
		nome = "Dan Prada";
		partes = nome.split(" ");
		System.out.println(partes[partes.length - 1]);
	}
}

//https://pt.stackoverflow.com/q/87810/101
