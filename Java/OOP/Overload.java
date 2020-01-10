class Classe {
     void metodo(float x) {
        System.out.printf("Float %f\n", x);
    }
     void metodo(double x) {
        System.out.printf("Double %f\n", x);
    }
}
 
class Ideone {
    public static void main(String args[]) {
        Classe classe = new Classe();
        classe.metodo(1);
        classe.metodo(1.0);
        classe.metodo(1.0f);
    }
}

//https://pt.stackoverflow.com/q/128247/101
