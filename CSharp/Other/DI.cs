public interface ILogger {
    void Logar(string mensagem);
}

public class LogEmArquivo : ILogger {
    void Logar(string mensagem) {
        //Loga a mensagem em um arquivo de log
    }
}

public class LogPorEmail : ILogger {
    void Logar(string mensagem) {
        //Envia a mensagem por email aos responsáveis
    }
}

public class Principal {
    private ILogger _logger;
    public Principal(ILogger logger) {
        _logger = logger;
    }
    public Principal() {
        _logger = new LogPorArquivo();
    }
    //Chamando métodos privados da classe Principal quando precisa logar alguma informação
    private void LogarInformacao(string informacao) {
        _logger.Logar(informacao);
    }
}

public static Aplicacao {
    public static void Main() {
        var logArq = new Principal(); //exemplo de uso
        var logMail = new Principal(new LogPorEmail()); //exemplo injetando a dependência
    }
}

//http://pt.stackoverflow.com/q/21319/101
