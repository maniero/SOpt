public bool EstaOn(LogAcesso acesso) => (acesso.DataAtual - acesso.DataAcesso).TotalDays < painel.TempoAtualizacaoAutomatica;

//https://pt.stackoverflow.com/q/45382/101
