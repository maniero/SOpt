using System;
using static System.Console;

public class Program {
    public static void Main() {
        var objeto = new AlgumaClasse();
        objeto.HoraEntrada = DateTime.Now;
        objeto.HoraSaida = DateTime.Now.AddHours(1).AddMinutes(43).AddSeconds(22);
        WriteLine($"Permaneceu {(objeto.TempoPermanencia().ToString(@"hh\:mm"))}");
    }
}

class AlgumaClasse {
    public DateTime HoraEntrada { get; set; }

    public DateTime HoraSaida { get; set; }

	public TimeSpan TempoPermanencia() {
        return HoraSaida - HoraEntrada;
    }
}

//http://pt.stackoverflow.com/q/182587/101
