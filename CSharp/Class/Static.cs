public static class Relatorio {
    public void Emitir(string consulta, string arquivo, Func<SQLiteCommand> metodoParametros) {
        //não gostei nada desse código, mas enfim....
        var reportViewer = new RdlViewer();
        var reportStrip = new ViewerToolstrip(ReportViewer);
        reportStrip.Viewer = ReportViewer;
        var query = new StringBuilder().Append(consulta);
        var dalConexao = dalConexao = new DALConexao(new DadosConexao().String_Conexao);
        var caminhoArquivo = new PathRelatorio(arquivo);
        if (caminhoArquivo.existeArquivo()) { //não gosto disto
            reportViewer.SourceFile = new Uri(caminhoArquivo.Path);
            reportViewer.Parameters += "conexao={dalConexao.Conexao.ConnectionString}";
            reportViewer.Report.DataSets["Data"].SetData(obterTabela(dalConexao, metodoParametros));
            reportViewer.Rebuild();
            reportViewer.HideRunButton();
            reportViewer.Dock = DockStyle.Fill;
        }
    }

    public void Emitir(string consulta, string arquivo) {
        Emitir(consulta, arquivo, dummy => {});
    }

    private DataTable obterTabela(string dalConexao, Func<SQLiteCommand> adicionarParametros) {
        var tabela = new DataTable();
        using (var conexao = dalConexao.Conexao)
        using (var command = conexao.CreateCommand()) {
            command.CommandType = CommandType.Text;
            command.CommandText = query.ToString();
            adicionarParametros(command);
            conexao.Open();
            using (var dataAdapter = new SQLiteDataAdapter(command)) {
                dataAdapter.Fill(tabela);
            }
        }
        return tabela;
    }
}

private void FormRunRelatorio_Load(object sender, EventArgs e) {
    switch (relatorioSelecionado) {
        case "GeralAluno":
            Relatorio.Emitir("SELECT nome, data_cadastro, telefone, celular, endereco, email, idade FROM Alunos, "relatorioGeralAlunos.rdl");
            break;
        case "GeralAlunoInativoOuAtivo":
            Relatorio.Emitir("SELECT nome, data_cadastro, telefone, celular, endereco, email, idade FROM Alunos ", "relatorioGeralAlunoAtivoInativo.rdl", ((command) => command.Parameters.Add("ativo", DbType.Int32).Value = 0));
            break;
        //case mais condicao...
        //    mais codigo...
    }
    Controls.Add(relGeralAluno.ReportStrip);
    Controls.Add(relGeralAluno.ReportViewer);
}

//https://pt.stackoverflow.com/q/120089/101
