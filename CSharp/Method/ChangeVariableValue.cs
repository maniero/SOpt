using static System.Console;
					
public class Program
{
	public static void Main() {}
	public static void OnGet() {
		string lcMenuPrincipal = "";
		lcMenuPrincipal  = CarregarMenu(lcMenuPrincipal);
		return;
	}

	public static string CarregarMenu(string lcMenuPrincipal) {
		WriteLine(lcMenuPrincipal); //estou fazendo alguma coisa com esse valor, caso contrário não sentido receber esse parâmetro
		return "Bom Dia Família";
	}
}

//https://pt.stackoverflow.com/q/391682/101
