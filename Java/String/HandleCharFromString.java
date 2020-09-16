class Main {
	public static void main(String[] args)	{
		solve("Teste");
	}
	public static void solve(String text) {
	    int len = text.length();
	    StringBuffer buffer = new StringBuffer(len);
	    for (int i = 0; i < len; i++){
	        char letter = text.charAt(i);
	        buffer.append(i % 2 == 0 ? Character.toUpperCase(letter) : Character.toLowerCase(letter));
	    }
	    System.out.println(buffer);
	}
}

//https://pt.stackoverflow.com/q/45347/101
