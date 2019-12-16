public abstract class Relatorio {
    private string nomeArquivo;
    private stringBuilder query = new StringBuilder();
    private DALConexao dalConexao;

    public RdlViewer ReportViewer { get; private set; } = new RdlViewer();

    public ViewerToolstrip ReportStrip { get; private set; }

    public Relatorio(DALConexao conexao, string consulta, string arquivo) {            
        dalConexao = conexao;
        //provavelmente dá para colocar na propriedade mas não posso testar
        ReportStrip = new ViewerToolstrip(ReportViewer);
        ReportStrip.Viewer = ReportViewer;
        query.Append(consulta);
        nomeArquivo = arquivo;
        emitir();
    }

    private void emitir() {
        //não gostei nada desse código, mas enfim....
        var caminhoArquivo = new PathRelatorio(nomeArquivo);
        if (caminhoArquivo.existeArquivo()) { //não gosto deisto
            ReportViewer.SourceFile = new Uri(caminhoArquivo.Path);
            ReportViewer.Parameters += string.Format("conexao={0}", dalConexao.Conexao.ConnectionString);
            ReportViewer.Report.DataSets["Data"].SetData(obterTabela());
            ReportViewer.Rebuild();
            ReportViewer.HideRunButton();
            ReportViewer.Dock = DockStyle.Fill;
        }
    }

    private DataTable obterTabela() {
        var tabela = new DataTable();
        using (var conexao = dalConexao.Conexao)
        using (var command = conexao.CreateCommand()) {
            command.CommandType = CommandType.Text;
            command.CommandText = query.ToString();
            AdicionarParametros(command);
            conexao.Open();
            using (var dataAdapter = new SQLiteDataAdapter(command)) {
                dataAdapter.Fill(tabela);
            }
        }
        return tabela;
    }

    protected virtual void AdicionarParametros(SQLiteCommand command) {}
}

public class RelAlunoAtivoOuInativo : Relatorio {
    public bool AtivoOuInativo { get; private set; }

    public RelAlunoAtivoOuInativo(DALConexao conexao, bool ativoOuInativo) : base(new DALConexao(new DadosConexao().String_Conexao), "SELECT nome, data_cadastro, telefone, celular, endereco, email, idade FROM Alunos ", "relatorioGeralAlunoAtivoInativo.rdl") {
        AtivoOuInativo = ativoOuInativo;
    }

    public RelAlunoAtivoOuInativo(bool ativoOuInativo) : this(new DALConexao(new DadosConexao().String_Conexao), ativoOuInativo) {}

    protected override void AdicionarParametros(SQLiteCommand command) {
        command.Parameters.Add("ativo", DbType.Int32).Value = AtivoOuInativo ? 1 : 0;
    }
}

public class RelGeralAluno : Relatorio {
    public RelGeralAluno(DALConexao conexao) : base(conexao, "SELECT nome, data_cadastro, telefone, celular, endereco, email, idade FROM Alunos, "relatorioGeralAlunos.rdl") {}

    public RelGeralAluno() : this(new DALConexao(new DadosConexao().String_Conexao)) {}
}

//https://pt.stackoverflow.com/q/120089/101
