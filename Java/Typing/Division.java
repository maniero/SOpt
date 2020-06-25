public class Main {
	public static void main (String[] args) {
		System.out.println(calculoPrevisao(new double[] { 10, 5.5, 7}));
	}
    public static double calculoPrevisao(double[] valores) {
        double[] values = new double[valores.length];
        return 2.0 / (values.length + 1);
    }
}

//https://pt.stackoverflow.com/q/252461/101
