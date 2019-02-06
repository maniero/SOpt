public class Program {
	public static void main (String[] args)	{
        int vet[] = new int[50];
        for (int i = 0; i < vet.length; i++) {
            if (i % 2 == 0) {
                vet[i] = (i + 1) * 2;
            }
        }
        for (int i = 0; i < vet.length; i++) {
       	if (vet[i] == vet[vet.length - i - 1]) {
                System.out.println(vet[i] + " É PALINDROMO");
            }
        }
	}
}

//https://pt.stackoverflow.com/q/188867/101
