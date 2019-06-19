import java.util.*;
import java.lang.*;
import java.io.*;
import java.text.*;

class Ideone {
	public static void main (String[] args) throws java.lang.Exception {
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss.SSS");
        Date date = sdf.parse("2015-01-24 17:39:50.000");
        System.out.println(date.getTime());
	}
}

//https://pt.stackoverflow.com/q/48149/101
