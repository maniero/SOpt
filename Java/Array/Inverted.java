class Main {
	public static void main (String[] args)	{
	    int[] firstArray = new int[10];
	    int[] secondArray = new int[10];
	    for (int i = 0; i < firstArray.length; i++) firstArray[i] =(int)Math.round(Math.random() * 50);
	    for (int i = firstArray.length - 1; i >= 0; i--) secondArray[secondArray.length - i - 1] = firstArray[i];
	    System.out.println("\nPrimeiro Array:");
	    for (int i = 0; i < firstArray.length; i++) System.out.print(firstArray[i] + "; ");
	    System.out.println("\nSegundo Array:");
	    for (int i = 0; i < secondArray.length; i++) System.out.print(secondArray[i] + "; ");
    }
}

//https://pt.stackoverflow.com/q/130712/101
