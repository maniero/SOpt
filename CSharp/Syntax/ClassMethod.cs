public class Menu {
    private static Random randomico = new Random();
    private static string[] Carnes = { "Rosbife", "Salame", "Peru", "Presunto", "Pastrami" };
    private static string[] Condimentos = { "Mostarda amarela", "Mostarda Marrom", "Mostarda com mel", "Maionese", "Molho Francês", "Gosto" };
    private static string[] Paes = { "Centeio", "Branco", "Trigo", "Pão italiano", "Pão integral", "árabe" };

    public string Item() {
        string ramdonCarne = Carnes[randomico.Next(Carnes.Lenght)];
        string ramdonCondimento = Condimentos[randomico.Next(Condimentos.Lenght)];
        string ramdonPao = Paes[randomico.Next(Paes.Lenght)];
        return ramdonCarne + " com " + ramdonCondimento + " no " + ramdonPao;
    }
}

//https://pt.stackoverflow.com/q/293689/101
