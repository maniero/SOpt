public final class ExceptionHandler implements Thread.UncaughtExceptionHandler {
    @Override  public void uncaughtException(Thread thread, Throwable throwable) {
        JOptionPane.showMessageDialog(null, "Erro: " + throwable.toString(), 
            "Erro", JOptionPane.ERROR_MESSAGE);
    }
}

//https://pt.stackoverflow.com/q/52845/101
