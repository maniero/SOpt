import java.math.*;

class ParImpar {
	public BigInteger totali;
	public BigInteger totalp;
	public ParImpar(BigInteger totali, BigInteger totalp) {
	    this.totali = totali;
	    this.totalp = totalp;
	}
	public static void main(String[] args) {
	    new ParImpar(BigInteger.ZERO, BigInteger.ONE).parImpar();
	}
	public void parImpar() {
	    for (BigInteger i = BigInteger.ONE; i.compareTo(BigInteger.valueOf(101)) != 0; i = i.add(BigInteger.ONE)) {
	        if (i.mod(BigInteger.valueOf(2)).compareTo(BigInteger.ZERO) != 0) totali = totali.add(i);
	        else totalp = totalp.multiply(i);
	    }
	    System.out.println("Total pares " + totalp);
	    System.out.println("Total impar " + totali);
	}
}

//https://pt.stackoverflow.com/q/388636/101
