import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

class Main {
    public static void main(String[] args) {
        Thread th = new Thread(new Runnable() { //cria uma thread
            public void run() {
                while(true) { //roda indefinidamente
                    Date date = Calendar.getInstance().getTime(); //pega a hora do sistema
                    DateFormat formatter = new SimpleDateFormat("HH:mm:ss");
                    String today = formatter.format(date);      
                    System.out.println(today);
                    try {
                        Thread.sleep(1000); //espera 1 segundo para fazer a nova evolução
                    } catch(InterruptedException ex){
                        //é algo terrível a se fazer mas pelo jeito a API medonha do Java exige
                    }
                }
            }
        });
        th.start();
    }
}

//https://pt.stackoverflow.com/q/46204/101
