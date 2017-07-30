/* package whatever; // don't place package name! */

class Ideone {
	public static void main (String[] args)	{
		for (int i : oddNumbers(2, 6)) {
			System.out.println(i);
		}
	}
	
	public static int[] oddNumbers(int l, int r) {
	    int odd[] = new int[(r - l) / 2 + (l % 2)];
	    l += l % 2 == 0 ? 1 : 0;
	    for (int i = 0; i < odd.length; i++) {
	        odd[i] = l + (i * 2);
	    }
	    return odd;
	}
}

//https://pt.stackoverflow.com/q/225246/101
