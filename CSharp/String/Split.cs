using static System.Console;

public class Test {
    public static void Main() {
        string texto = "_2910_0908_401 _600_ERV__P_119552_GUARITA ERV SEM ENERGIA RADIO INOPERAN_TE SEMAFOROS P TRENS E VEICLS APAGADOS_PSG TREM C SINAL DE BANDEIRA PELA GUAR_ITA";
        string[] partes = texto.Substring(1).Split('_');
        partes[0] = "_" + partes[0];
        foreach(string parte in partes) WriteLine(parte);
    }
}

//https://pt.stackoverflow.com/q/38521/101
