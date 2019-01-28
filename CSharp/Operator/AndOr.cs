using System;
using static System.Console;

public class Program {
    public static void Main() {
        var horaC1 = new DateTime(2019, 1, 1, 23, 0, 0).TimeOfDay;
        var horaC2 = new DateTime(2019, 1, 2, 6, 0, 0).TimeOfDay;
        var now = new DateTime(2019, 1, 2, 5, 0, 0).TimeOfDay;
        if (now >= horaC1 || now <= horaC2) WriteLine("Turno 3");
        now = new DateTime(2019, 1, 2, 7, 0, 0).TimeOfDay;
        if (now >= horaC1 || now <= horaC2) WriteLine("Turno 3 ---");
    }
}

//https://pt.stackoverflow.com/q/357631/101
