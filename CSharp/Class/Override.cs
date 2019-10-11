abstract class interface Log {
    bool save(string msg) {
        if (processMedia(msg)) {
            print "logou!";
            return true;
        } else {
            print "o log falhou!";
            return false;
        }
    }
    virtual bool processMedia(string msg);
}

class LogFile extends Log {
    override bool processMedia(string msg) { 
        try {
            //salva em arquivo aqui
            return true;
        } catch (IOException ex) {
            return false;
        }
    }
}

classe LogMail extends Log {
    override bool processMedia(string msg) {
        try {
            //envia por e-mail aqui
            return true;
        } catch (SMTPException ex) {
            return false;
        }
}

bool logou = new LogFile().save("deu um erro X aqui neste trecho");

//https://pt.stackoverflow.com/q/89309/101
