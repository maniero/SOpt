class Main {
	public static void main (String[] args)	{
		for (int i : oddNumbers(2, 5)) System.out.println(i);
	}
	
	public static int[] oddNumbers(int l, int r) {
		l += 1 - l % 2;
		r -= 1 - r % 2;
	    int odd[] = new int[(r - l) / 2 + 1];
	    for (int i = 0; i < odd.length; i++) odd[i] = l + (i * 2);
	    return odd;
	}
}

//https://pt.stackoverflow.com/q/225246/101
