class Program {
	public static void main (String[] args) {
		System.out.println(Right("OlaMundo", 3));
	}

	public static String Right(String text, int length) {
		if (text.length() <= length) return null;
		return text.substring(text.length() - length);
	}
}

//https://pt.stackoverflow.com/q/349464/101
