public int VerificaUltimaAnalise() {
    //Desenvolvimento
    WFExecutor vcmpExecutor = null;
    WFAnalise vcmpAnalise = null;
    Core vmpaCore = null;
    int vintCdTransacao = 0;
    int vintCdProxProcesso = 0;
    int vintCdAnalise = 0;
    try {
        //Instâncias e Inicializalções
        vcmpExecutor = new WFExecutor();
        vcmpAnalise = new WFAnalise();
        vmpaCore = (Core)Page.Master;
        //Desenvolvimento
        //vintCdTransacao = vcmpExecutor.ConsultarTransacao(Request.Path.Substring(Request.Path.LastIndexOf("/") + 1));
        vintCdProxProcesso = vcmpAnalise.ProximoProcessoAnalise(vintCdTransacao, int.Parse(hdfCdUsuario.Value), ref vintCdAnalise);
        return vintCdProxProcesso;
    } catch (Exception Ex) {
        Mensagem = (wucMensagens)Page.Master.FindControl("wucMasterMensagens");
        Mensagem.ExibirMensagem(wucMensagens.TipoAlerta.Erro, Ex.Source, Ex.Message, Ex.StackTrace);
        return 0;
    }
}

//https://pt.stackoverflow.com/q/48028/101
