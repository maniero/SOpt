import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Program {
	public static void main(String[] args) throws Exception {
	    Matcher fonte = (Pattern.compile("test")).matcher("teste de regex");
	    System.out.println(fonte.find());
	    System.out.println(fonte.matches());
	}
}

//https://pt.stackoverflow.com/q/242446/101
