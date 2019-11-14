class Main {
	public static void main (String[] args) {
		System.out.println(countVirgulas("30,60,90"));
	}
    static int countVirgulas(String parametro) {
    	int count = 0;
        for (char caractere : parametro.toCharArray()) {
            if (caractere == ',') {
                count++;
            }
        }
        return count;
    }
}

//https://pt.stackoverflow.com/q/106096/101
