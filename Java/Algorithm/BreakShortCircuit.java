class Program {
	static String[] listaUsuarios = new String[] { "1", "12", "123" };
	public static void main (String[] args) throws java.lang.Exception {
		System.out.println(autentica("123"));
		System.out.println(autentica("456"));
	}
	public static boolean autentica (String usuario) {
	    for(int i = 0; i < listaUsuarios.length; i++) {
    	    if(usuario.equals(listaUsuarios[i])) {
        	    return true;
        	}
    	}
    	//opcionalmente faz alguma coisa aqui.
    	return false;
	}
}

//https://pt.stackoverflow.com/q/48512/101
