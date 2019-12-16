public class Relatorio {
    private string nomeArquivo;
    private stringBuilder query = new StringBuilder();
    private DALConexao dalConexao = new DALConexao(new DadosConexao().String_Conexao);

    public RdlViewer ReportViewer { get; private set; } = new RdlViewer();

    public ViewerToolstrip ReportStrip { get; private set; }

    public Func<SQLiteCommand> AdicionarParametros { get; private set; } = dummy => {};

    public Relatorio(string consulta, string arquivo) {            
        ReportStrip = new ViewerToolstrip(ReportViewer);
        ReportStrip.Viewer = ReportViewer;
        query.Append(consulta);
        nomeArquivo = arquivo;
        emitir();
    }

    public Relatorio(string consulta, string arquivo, Func<SQLiteCommand> metodoParametros) : this (consulta, arquivo) {            
        AdicionarParametros = metodoParametros;
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
}

public class RelAlunoAtivoOuInativo {
    public bool AtivoOuInativo { get; private set; }

    public RelAlunoAtivoOuInativo(bool ativoOuInativo) : base("SELECT nome, data_cadastro, telefone, celular, endereco, email, idade FROM Alunos ", "relatorioGeralAlunoAtivoInativo.rdl", ((command) => command.Parameters.Add("ativo", DbType.Int32).Value = ativoOuInativo ? 1 : 0)) {}
}

public class RelGeralAluno {
    public RelGeralAluno() : base("SELECT nome, data_cadastro, telefone, celular, endereco, email, idade FROM Alunos, "relatorioGeralAlunos.rdl") {}
}

//https://pt.stackoverflow.com/q/120089/101
