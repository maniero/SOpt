class Porta {
	static int portasAbertas = 0;
	private boolean aberta;
	public String cor;
	public int dimensaoX, dimensaoY, dimensaoZ;
	
	public void abre() {
        if (!aberta) {
   		    portasAbertas++;
		    aberta = true;
        }
	}
	
	public void fecha() {
       if (aberta) {
		    portasAbertas--;
		   aberta = false;
       }
	}
	
	public void pinta(String novaCor) {
	    cor = novaCor;
	}
	
	public void abreFecha(int respUsuario) {
	    switch (respUsuario) {
	        case 1:
	            abre();
	            System.out.println("A porta está aberta.\n");
	        break;
	        case 2:
	            fecha();
	            System.out.println("A porta está fechada.\n");
	        break;
	    }
	} 
	
	public static int quantasPortasEstaoAbertas() {
	    return portasAbertas; 
	}
}

class Programa2 {
    public static void main(String[] args) {
	    Porta minhaPorta1;
	    minhaPorta1 = new Porta();
	    minhaPorta1.dimensaoX = 100;
	    minhaPorta1.dimensaoY = 80;
	    minhaPorta1.dimensaoZ = 30;
	    minhaPorta1.pinta("Verde");
	    System.out.println("A porta é: " + minhaPorta1.cor + " e as dimensões são " + minhaPorta1.dimensaoX + ", " + minhaPorta1.dimensaoY + ", " + minhaPorta1.dimensaoZ + ".");
	    minhaPorta1.abreFecha(1);
	
	    Porta minhaPorta2;
	    minhaPorta2 = new Porta();
	    minhaPorta2.dimensaoX = 120;
	    minhaPorta2.dimensaoY = 90;
	    minhaPorta2.dimensaoZ = 40;
	    minhaPorta2.pinta("Azul");
	    System.out.println("A porta é: " + minhaPorta2.cor + " e as dimensões são " + minhaPorta2.dimensaoX + ", " + minhaPorta2.dimensaoY + ", " + minhaPorta2.dimensaoZ + ".");
	    minhaPorta2.abreFecha(2);
	
	    Porta minhaPorta3;
	    minhaPorta3 = new Porta();
	    minhaPorta3.dimensaoX = 70;
	    minhaPorta3.dimensaoY = 60;
	    minhaPorta3.dimensaoZ = 10;
	    minhaPorta3.pinta("Amarela");
	    System.out.println("A porta é: " + minhaPorta3.cor + " e as dimensões são " + minhaPorta3.dimensaoX + ", " + minhaPorta3.dimensaoY + ", " + minhaPorta3.dimensaoZ + ".");
	    minhaPorta3.abreFecha(2);
	    
	    System.out.println(Porta.quantasPortasEstaoAbertas());
	}
}

//https://pt.stackoverflow.com/q/141148/101
