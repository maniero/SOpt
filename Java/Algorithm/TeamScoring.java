class HelloWorld {
	public static void main (String[] args)	{
		Time time = new Time("Meu time");
		time.ganharPartida();
		time.empatarPartida();
		time.perderPartida();
		time.ganharPartida();
		System.out.println(time.Estatisticas());
	}
}

final class Time {
	private String nome;
	private int vitorias;
	private int empates;
	private int derrotas;
	private int numPartidas;
	private int pontos;
	private float aproveitamento;
	
	public Time(String nome) {
	    this.nome = nome;
	}
	public void ganharPartida() {
	    vitorias++;
	    pontos += 3;
	    numPartidas++;
	    CalcAproveitamento();
	}
	public void empatarPartida() {
	    empates++;
	    pontos++;
	    numPartidas++;
	    CalcAproveitamento();
	}
	public void perderPartida() {
	    derrotas++;
	    numPartidas++;
	    CalcAproveitamento();
	}
	public String getNome() {
	    return nome;
	}
	public void setNome(String nome) {
	    this.nome = nome;
	}
	public int getVitorias() {
	    return vitorias;
	}
	public void setVitorias(int vitorias) {
	    this.vitorias = vitorias;
	    CalcAproveitamento();
	}
	public int getEmpates() {
	    return empates;
	}
	public void setEmpates(int empates) {
	    this.empates = empates;
	    CalcAproveitamento();
	}
	public int getDerrotas() {
	    return derrotas;
	}
	public void setDerrotas(int derrotas) {
	    this.derrotas = derrotas;
	    CalcAproveitamento();
	}
	public int getNumPartidas() {
	    return numPartidas;
	}
	public void setNumPartidas(int numPartidas) {
	    this.numPartidas = numPartidas;
	    CalcAproveitamento();
	}
	public float getAproveitamento() {
	    return aproveitamento;
	}
	private void CalcAproveitamento() {
	    this.aproveitamento = (float)pontos / (numPartidas * 3) * 100;
	}
	public int getPontos() {
	    return pontos;
	}
	public void setPontos(int pontos) {
	    this.pontos = pontos;
	}
	public String Estatisticas() {
	    return "Time{" + "nome=" + nome + ", vitorias=" + vitorias + ", empates=" + empates + ", derrotas=" + derrotas + ", numPartidas=" + numPartidas + ", pontos=" + pontos + ", aproveitamento=" + aproveitamento + '}';
	}
}

//https://pt.stackoverflow.com/q/228218/101
