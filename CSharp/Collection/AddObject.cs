var pessoas = new List<ClsPessoa>();
pessoas.Add(new ClsPessoa() {Nome = TXT_Nome.Text,
                             DataNascimento = DTP_DataNascimento.DisplayDate,
                             Email = TXT_Email.Text});

pessoas[0] = new ClsPessoa() {Nome = TXT_Nome.Text,
                              DataNascimento = DTP_DataNascimento.DisplayDate,
                              Email = TXT_Email.Text});


pessoas[0].Email = TXT_Email.Text;

public class Pessoa {
    public Pessoa(string nome, DateTime dataNascimento, string email) {
        Nome = nome ?? ""; //esquisito, mas é o que tinha no código original
        DataNascimento = dataNascimento;
        Email = email ?? "";
    }
    public string Nome { get; set;}
    public DateTime DataNascimento { get; set; }
    public string Email { get; set; }
}

//https://pt.stackoverflow.com/q/91852/101
