import java.util.Scanner;

class HelloWorld {
    public static void main(String[] args) {
	    Scanner sc = new Scanner(System.in);
	    int a = sc.nextInt();
	    int[] v = new int[a];
	    for (int i = 0; i < a; i++) v[i] = sc.nextInt();
	    funcao(v);
	    for (int i = 0; i < a; i++) System.out.println(v[i]);
	}

    static void funcao(int[] v) {
        for (int j = 1; j < v.length; j++) {
            for (int i = 1; i < v.length; i++) {
    		    if (v[i] < v[i - 1]) {
    		        int temp = v[i];
    		        v[i] = v[i - 1];
    		        v[i - 1] = temp;
    			}
    		}
        }
	}
}

//https://pt.stackoverflow.com/q/164293/101
