class comportamento {
    public ficarTriste() {}
    public ficarFeliz() {}
 }

 class acao {
    public falar(texto) {
        console.log(texto);
	}
	public olhar(endereco) {
        return console.log(endereco);
    }
 }

 class serHumano implements comportamento, acao {
	public ficarTriste() {}
    public ficarFeliz() {}
     public falar(texto) {
        console.log(texto);
	}
	public olhar(endereco) {
        return console.log(endereco);
    }
}

//https://pt.stackoverflow.com/q/216029/101
