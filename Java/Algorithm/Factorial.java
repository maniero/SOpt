class Main {
	public static void main (String[] args)	{
	    int f = 1; 
	    int c = 5; 
	    String s = ""; 
	    while (c > 1) { 
	        f *= c;
            s += c + " x " ;
	        c--;
	    }
        s += c;
	    System.out.println(s + " = " + f);
    }
}

//https://pt.stackoverflow.com/q/150555/101
