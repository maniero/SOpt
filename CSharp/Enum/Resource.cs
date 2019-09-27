using System;
using System.Resources;
using System.Reflection;
					
public class Program {
	public static void Main() {
		var area = SystemArea.Gestor;
		Console.WriteLine(area.Display());
	}
}

public static class SystemAreaExtension {
    public static string Display(this SystemArea value) {
        var compare = new ResourceManager("SystemArea", Assembly.GetExecutingAssembly())
                        .GetString("SystemArea_" + value);
        return string.IsNullOrEmpty(compare) ? value.ToString() : compare;
    }
    public static string Display(this Enum value) {
        var compare = new ResourceManager("SystemArea", Assembly.GetExecutingAssembly())
                    .GetString("SystemArea_" + value);
        return string.IsNullOrEmpty(compare) ? value.ToString() : compare;
    }
}

public enum SystemArea {
    Gestor = 3,
    Administrador = 2,
    Professor = 1,
    Aluno = 0,
}

//https://pt.stackoverflow.com/q/82946/101
