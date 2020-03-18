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
    public string Placa { get; set; }
 
    public string Modelo { get; set; }

	private DateTime horaEntrada;
	public DateTime HoraEntrada {
		get => horaEntrada;
		set {
			var tempo = default(DateTime).Add(value.TimeOfDay);
			horaEntrada = tempo.AddSeconds(-tempo.Second);
		}
	}

	private DateTime horaSaida;
	public DateTime HoraSaida {
		get => horaSaida;
		set {
			var tempo = default(DateTime).Add(value.TimeOfDay);
			horaSaida = tempo.AddSeconds(-tempo.Second);
		}
	}
    public TimeSpan TempoPermanencia() => HoraSaida - HoraEntrada;
}

//https://pt.stackoverflow.com/q/163203/101
