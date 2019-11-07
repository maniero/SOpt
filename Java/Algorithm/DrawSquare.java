class Main {
	public static void main (String[] args) {
		int altura = 5;
		int largura = 5;
		for (int j = 0; j < largura; j++) System.out.print("* ");
        System.out.print("\n");
        for (int i = 2; i < altura; i++) {
    		System.out.print("* ");
	        for (int j = 2; j < largura; j++) System.out.print("  ");
	        System.out.print("* \n");
	    } 
		for (int j = 0; j < largura; j++) System.out.print("* ");
	}
}

//https://pt.stackoverflow.com/q/420189/101
