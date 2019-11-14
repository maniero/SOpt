class Main {
	public static void main (String[] args) {
		System.out.println(countVirgulas("30,60,90"));
	}
    static int countVirgulas(String parametro) {
        int count = 0;
        for (int i = 0; i < parametro.length(); i++) {
            if (parametro.charAt(i) == ',') {
                count++;
            }
        }
        return count;
    }
}

//https://pt.stackoverflow.com/q/106096/101
