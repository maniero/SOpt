import java.io.*;

class Main {
	public static void main (String[] args)	{
		String dirPath = "/home/daniela/oknok/data/uploads/23980dc32e16792007de3343f1f99211/";
		System.out.println(dirPath.substring(dirPath.substring(0, dirPath.length() - 1).lastIndexOf("/")));
    	System.out.println(new File(dirPath).getName());
    	System.out.println("/" + new File(dirPath).getName() + "/");
	}
}

//https://pt.stackoverflow.com/q/54733/101
