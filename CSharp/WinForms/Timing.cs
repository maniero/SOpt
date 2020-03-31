using static System.Console;
using System.Timers;

public class Program {
    public static void Main() {
        var aTimer = new Timer();
        aTimer.Elapsed += new ElapsedEventHandler(OnTimed);
        aTimer.Interval = 30000;
        aTimer.Enabled = true;
        ReadLine();
    }

    private static void OnTimed(object source, ElapsedEventArgs e) {
        if (NetworkInterface.GetIsNetworkAvailable()) {
            //faz alguma coisa aqui
        } else {
            //pode fazer algo se a rede caiu
        }
    }
}

//https://pt.stackoverflow.com/q/171888/101
