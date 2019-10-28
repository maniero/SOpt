class Main {
	public static void main (String[] args) throws java.lang.Exception {
		System.out.println(teste());
	}
	
	public static boolean teste() throws java.lang.Exception {
		try {
            System.out.println("Parte 1");
            metodo();
            return false;
        } catch (Exception ex) {
            System.out.println("Parte 2");
            throw new Exception();
        }
	}
	
	public static void metodo() throws java.lang.Exception {
		throw new Exception();
	}
}

class Main  {
	public static void main (String[] args) throws java.lang.Exception {
		System.out.println(teste());
	}
	
	public static boolean teste() throws java.lang.Exception {
		try {
            System.out.println("Parte 1");
            metodo();
            return false;
        } catch (Exception ex) {
            System.out.println("Parte 2");
        }
	}
	
	public static void metodo() throws java.lang.Exception {
		throw new Exception();
	}
}

////https://pt.stackoverflow.com/q/98068/101
