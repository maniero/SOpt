class TomadaDeDoisPinos implements TomadaDeDoisPinosIF {
	@Override 
	public void conectar(ConectorDeDoisPinos conector) {
		System.out.println(conector.getDescricao());  
	} 
}
 
class ConectorDeDoisPinos {
	protected String descricao;    
	 
	public String getDescricao() {  
		this.descricao = " conector de dois pinos."; 
		return this.descricao;   
	} 

}

class CarregadorAntigo extends ConectorDeDoisPinos {
	@Override 
	public String getDescricao(){  
		this.descricao = " conector de dois pinos."; 
	    return "Carregador antigo conectando a tomada de " + descricao;   
	}    
}

interface TomadaDeDoisPinosIF { 
	public void conectar(ConectorDeDoisPinos conector);
	
} 

class Teste {
	public static void main(String[] args) {
		ConectorDeDoisPinos cAntigo = new CarregadorAntigo();
		TomadaDeDoisPinos tomadaDeDoisPinos = new TomadaDeDoisPinos();
		tomadaDeDoisPinos.conectar(cAntigo);       
		 
	}   
}

//https://pt.stackoverflow.com/q/102981/101
