using static System.Convert;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
					
public class Program {
	public static void Main() {
		List<Ata> lstAtas = new List<Ata>() {
                new Ata{ NroAta = "1"},
                new Ata{ NroAta = "10"},
                new Ata{ NroAta = "6"},
                new Ata{ NroAta = "4"},
                new Ata{ NroAta = "5"},
                new Ata{ NroAta = "2"},
                new Ata{ NroAta = "3"},
		};
		foreach (var ata in lstAtas.OrderBy(x => ToInt32(x.NroAta))) WriteLine(ata.NroAta);
	}
}
public class Ata {
	public string NroAta;
}

//https://pt.stackoverflow.com/q/152015/101
