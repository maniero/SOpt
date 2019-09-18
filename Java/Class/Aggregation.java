public class Pessoa implements Serializable {
    private static final long serialVersionUID = 1L;

    private int codigo;
    private String descricao;
    private String dataNascimento;
    private String cpfcnpj;
    private ArrayList<PessoaEndereco> Enderecos;
    
//https://pt.stackoverflow.com/q/78454/101
