public class Main { 
	public static void main(String[] args) {
	    int[][] img = {
	    { 1, 1, 1, 1, 1, 1, 1, 1 },
	    { 0, 1, 0, 1, 1, 1, 0, 0 },
	    { 0, 0, 0, 0, 0, 0, 0, 0 },
	    { 1, 1, 1, 1, 1, 1, 1, 1 }, 
	    { 1, 1, 1, 1, 1, 1, 1, 1 },
	    { 1, 1, 1, 1, 1, 1, 1, 1 },
	    { 1, 1, 0, 0, 1, 1, 1, 0 }, 
	    { 0, 0, 0, 0, 0, 0, 0, 0 },};
	    int ppreto = 0;
	    int pbranco = 0;
	    int linhaPreta = 0;
	    int linhaBranca = 0;
	    for (int i = 0; i < img.length; i++) {
	    	int itensPreto = 0;
	    	int itensBranco = 0;
	        for (int j = 0; j < img[i].length; j++) {
		         if (img[i][j] == 0) {
    	             ppreto++;
	                 itensPreto++;
	            }
	            if (img[i][j] == 1) {
	                pbranco++;
	                itensBranco++;
	            }
            }
            if (itensPreto == img[i].length) linhaPreta++;
            if (itensBranco == img[i].length) linhaBranca++;
	    }
	    System.out.print("qtde ponto preto = " + ppreto + "\n");
	    System.out.print("qtde ponto branco = " + pbranco + "\n");
	    System.out.print("Qtd linha preta = " + linhaPreta + "\n");
	    System.out.print("Qtd linha branca= " + linhaBranca + "\n");
	}
}

//https://pt.stackoverflow.com/q/43702/101
