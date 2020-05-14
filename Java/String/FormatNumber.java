public class Formatar {
    static DecimalFormat df = new DecimalFormat("###,###,###");

    public static String formatar(int valorFormatar) {
       return df.format(valorFormatar);
    }
}

//https://pt.stackoverflow.com/q/200157/101
