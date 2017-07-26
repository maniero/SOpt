public class Cliente {
    public Cliente() {} //tem certeza que quer impedir a construção?

    public void gravar() {
        var cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|C:\Users\Antonio Viana\documents\visual studio 2017\Projects\Loja\Eccomerce\App_Data\dados.mdf;Integrated Security=True");
        cn.Open();
        using (var cmd = new SqlCommand()) {
            cmd.CommandText= "Insert Into Cliente (codigo,nome,email,sexo,estado,senha,data,celular,cpf,cidade,cep,confirmar, rua,numero,bairro,uf,login,telefone) values(@codigo,@nome,@email,@sexo,@estado,@senha,@data,@celular,@cpf,@cidade,@cep,@confirmar,@rua,@numero,@bairro,@uf,@login,@telefone)";
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@codigo", this._codigo);
            //... aqui terá os outros campos, certo?
            cmd.ExecuteNonQuery();
        }
    }
    private int _codigo;
    public int Codigo {
        get { return _codigo; }
        set {
            if (value < 0) {
                throw new Eccomerce.Excecoes.ValidacaoException("O codigo do cliente não pode ser negativo"); //vai lançar exceção mesmo?
                _codigo = 0;
            }
            _codigo = value;
        }
    }
    private String _nome;
    public String Nome 
        get { return _nome; }
        set {
            if (value.Length <= 10) {
                throw new Eccomerce.Excecoes.ValidacaoException("O nome deve ter no minimo 3 10 caracteres");
                _nome = value;
            }
        }
    }
    public String email { get; set; }
    public String sexo { get; set; }
    public String estado { get; set; }
    public String senha { get; set; }
    public String data { get; set; }
    public String celular { get; set; }
    public String cpf { get; set; }
    public String cidade { get; set; }
    public String cep { get; set; }
    public String confirmar { get; set; }
    public String rua { get; set; }
    public String numero { get; set; }
    public String bairro { get; set; }
    public String uf { get; set; }
    public String login { get; set; }
    public String telefone { get; set; }
}
    
//https://pt.stackoverflow.com/q/221458/101
