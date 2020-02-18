import java.util.Scanner;

abstract class Forma {
    public void imprime() {
        System.out.println("Área: " + area());
        System.out.println("Perímetro: " + perimetro());
    }
    public abstract double area();
    public abstract double perimetro();

}

class Retangulo extends Forma {
    private double comprimento;
    private double largura;

    Retangulo(double comprimento, double largura) throws Exception {
        if (comprimento <= 0 || largura <= 0) throw new Exception("ONDE JÁ SE VIU LARGURA E/OU COMPRIMENTO NEGATIVO?");
        this.comprimento = comprimento;
        this.largura = largura;
    }

    @Override
    public double area() {
        return comprimento * largura;
    }
    @Override
    public double perimetro() {
        return 2 * (largura + comprimento);
    }
    public double getComprimento() {
        return comprimento;
    }
    public double getLargura() {
        return largura;
    }
    public void setComprimento(double comprimento) throws Exception {
        if (comprimento < 0) throw new Exception("ONDE JÁ SE VIU COMPRIMENTO NEGATIVO?");
        this.comprimento = comprimento;
    }
    public void setLargura(double largura) throws Exception {
        if (largura < 0) {
            throw new Exception("ONDE JÁ SE VIU LARGURA NEGATIVA?");
        }
        this.comprimento = largura;
    }
}

class Programa {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double comprimento = sc.nextDouble();
        double largura = sc.nextDouble();
        try {
            Retangulo retangulo = new Retangulo(comprimento, largura);
            retangulo.imprime();
            retangulo.setComprimento(-comprimento);
        } catch (Exception ex) {
   	        System.out.println(ex.getMessage());
        }
    }
}

//https://pt.stackoverflow.com/q/148081/101
