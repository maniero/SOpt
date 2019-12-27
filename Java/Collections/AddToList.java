import java.util.ArrayList;

class Ideone {
	public static void main (String[] args)	{
		ArrayList<Pessoa> pessoas = new ArrayList<>();
		pessoas.add(new Pessoa(1, "joão", 'M', "9999-9999"));
		pessoas.add(new Pessoa(2, "maria", 'F', "9999-9991"));
		for (Pessoa pessoa : pessoas) System.out.println(pessoa.getNome());
	}
}

class Pessoa {
    private int id;
    private String nome;
    private char sexo;
    private String telefone;

    Pessoa(int id, String nome, char sexo, String telefone){
        this.id = id;
        this.nome = nome;
        this.sexo = sexo;
        this.telefone = telefone;
    }

    public int getId() { return this.id; }
    public void setId(int id) { this.id = id; }

    public String getNome(){ return this.nome; }
    public void setNome(String nome) { this.nome = nome; }

    public char getSexo() { return this.sexo; }
    public void setSexo(char sexo) { this.sexo = sexo; }

    public String getTelefone() { return this.telefone; }
    public void setTelefone(String telefone) { this.telefone = telefone;}
}

//https://pt.stackoverflow.com/q/123921/101
