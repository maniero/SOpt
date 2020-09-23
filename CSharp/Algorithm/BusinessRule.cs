private List<RetornoRomaneioPostagem> BaixadoNRetornado(List<RetornoRomaneioPostagem> baixasNRetornadas) {
    try {
        var nRetorndasBaixadas = new List<RetornoRomaneioPostagem>();
        var retornoRPostagem = new RetornoRomaneioPostagem();
        if (baixasNRetornadas.Any(b => b.Numero_Auto == retornoRPostagem.Numero_Auto && b.Tipo_Notificacao == retornoRPostagem.Tipo_Notificacao)) {
            nRetorndasBaixadas.Add(retornoRPostagem);
            return nRetorndasBaixadas;
        } else {
            return null;
        }
    } catch (Exception ex) {
        clog.ArquivoLog("Alguma informação relevante aqui, não qualquer coisa", ex);
        throw;
    }
}

//https://pt.stackoverflow.com/q/55764/101
