class Ideone {
	public static void main (String[] args) {
		Usuario usuario = new Usuario();
	    usuario.listar();
	    new Usuario().listar();
	}
}

class Usuario {
	public void listar() {
	    System.out.println("listou");
	}
}

//https://pt.stackoverflow.com/q/160659/101
