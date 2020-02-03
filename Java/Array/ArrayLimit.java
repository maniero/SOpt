class Main {
  public static void main(String[] args) {
		Olho[] ol = new Olho[2];
		ol[0] = new Olho("Castanho", true);
		ol[1] = new Olho("Azul", false);
		ol[0].verificar();
  }
}

class Olho {
	private String cor;
	private boolean funciona;
	public String getCor() {
		return cor;
	}
	public void setCor(String cor) {
		this.cor = cor;
	}
	public Boolean getFunciona() {
		return funciona;
	}
	public void setFunciona(Boolean funciona) {
		this.funciona = funciona;
	}
	public Olho(String cor, Boolean funciona) {
		this.cor = cor;
		this.funciona = funciona;
	}
	public void verificar() {
		System.out.println("A cor do olho é: " + getCor());
		System.out.println("O olho funciona ? " + getFunciona());
	}
}

//https://pt.stackoverflow.com/q/433966/101
