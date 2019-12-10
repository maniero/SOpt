class Teste {
	public static void main(String[] args) {
	    Pessoa pessoa = new Pessoa();           
	    pessoa.setNome("Aline");
	    pessoa.setSobrenome("Gonzaga");
	    pessoa.setEndereco("Bairro Barra");
	    Telefone telefones[] = new Telefone[3];
	    Telefone telefoneTemp = new Telefone();
	    telefoneTemp.setTelefone("7627-86476");
	    telefones[0] = telefoneTemp;
	    telefoneTemp = new Telefone();
	    telefoneTemp.setTelefone("5362-56423");
	    telefones[1] = telefoneTemp;
	    telefoneTemp = new Telefone();
	    telefoneTemp.setTelefone("33333-3333");
	    telefones[2] = telefoneTemp;
	    pessoa.setTels(telefones);
	    System.out.println(pessoa.getNome());
	    System.out.println(pessoa.getSobrenome());
	    System.out.println(pessoa.getEndereco());
	    for (Telefone telefone : pessoa.getTels()) System.out.println(telefone.getTelefone());
	}
}

class Telefone {
	private String telefone;
	public String getTelefone() {
	    return telefone;
	}
	public void setTelefone(String telefone) {
	    this.telefone = telefone;
	}
}

class Pessoa {
	private String nome;
	private String endereco;
	private String sobrenome;
	private Telefone tels[];
	public Telefone[] getTels() {
	    return tels;
	}
	public void setTels(Telefone[] tels) {
	    this.tels = tels;
	}
	public String getNome() {
	    return nome;
	}
	public void setNome(String nome) {
	    this.nome = nome;
	}
	public String getEndereco() {
	    return endereco;
	}
	public void setEndereco(String endereco) {
	    this.endereco = endereco;
	}
	public String getSobrenome() {
	    return sobrenome;
	}
	public void setSobrenome(String sobrenome) {
	    this.sobrenome = sobrenome;
	}
}

//https://pt.stackoverflow.com/q/119026/101
