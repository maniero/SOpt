class Program {
	public static void main(String[] args) {
		String text = "1 - -- * d 2";
	    String[] tokens = "1 - -- * d 2".split("--");
	    for (String token : tokens) {
	        System.out.println(token);
	    }
	}
}

//https://pt.stackoverflow.com/q/394373/101
