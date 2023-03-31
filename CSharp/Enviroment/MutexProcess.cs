using System.Threading;

public class Program {
    static Mutex mutex = new Mutex(true, "Nome que eu escolhi");
    static void Main() {
        if (!mutex.WaitOne(TimeSpan.Zero, true)) return;
        //continua aqui
    }
}

//https://pt.stackoverflow.com/q/580660/101
