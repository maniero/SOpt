public class Rope {
    static String result = "";
    static {result += "u";}
    {result += "c";}
    {result += "r";}

    public static void main(String[] args) {
        System.out.print(Rope.result + " ");
        System.out.print(Rope.result + " ");
        new Rope();
        new Rope();
        System.out.print(Rope.result + " ");
    }
}

//https://pt.stackoverflow.com/q/254100/101
