public class Main {
    public static void main(String []args) {
        int numero = 123456;
        long time = System.nanoTime();
        for (int i = 0; i < 10000000; i++) {
            int resultado = 0;
            while (numero != 0) {
                numero /= 10;
                resultado += numero % 10;
            }
        }
        System.out.println((System.nanoTime() - time) + "ns");
        time = System.nanoTime();
        for (int i = 0; i < 10000000; i++) {
            String texto = String.valueOf(numero);
            int resultado = 0;
            for (char digito : texto.toCharArray()) {
                resultado = resultado + Character.getNumericValue(digito);
            }
        }
        System.out.println((System.nanoTime() - time) + "ns");
    }
}

//https://pt.stackoverflow.com/q/258430/101
