static Logger log = Logger.getLogger(ClassePrincipal.class);
try {
    chamaAplicacao();
} catch (Exception ex) { //o único lugar onde capturar Exception faz sentido
    log.error("um erro ocorreu: " + ex.getMessage()); //talvez um printStackTrace() tb
}

//https://pt.stackoverflow.com/q/83548/101
