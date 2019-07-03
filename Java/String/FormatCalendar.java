import java.util.*;
import java.text.*;

class Program {
	public static void main (String[] args) {
		System.out.println(new SimpleDateFormat("dd-MM-yyyy HH:mm:ss").format(Calendar.getInstance().getTime()));
	}
}

//https://pt.stackoverflow.com/q/49227/101
