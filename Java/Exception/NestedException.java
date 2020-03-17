class Teste {
    public static void main(String[] args) {
        func1();
    }
 
    public static void func1() {
        try {
            func2();
        } catch (Exception e) {
            System.out.println("Error 1");
        }
    }
 
    public static void func2() {
        try {
            int x = 1 / 0;
        } catch (Exception e) {
            System.out.println("Error 2");
            throw e;
        }
    }
}
 
//https://pt.stackoverflow.com/q/160541/101
