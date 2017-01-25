interface Something {
    void doSomething();
}

interface Otherthing {
    void doOtherSomething();
}

class Whatever implements Something, Otherthing {
    public void doSomething() {
       System.out.println("Do something !");
    }     
    public void doOtherSomething() {
       System.out.println("Do otherthing !");
    }
}

class Test {
    public static void main(String[] arguments) {
        Something s = new Whatever();
        s.doSomething();
        Otherthing w = new Whatever(); 
        w.doOtherSomething();
    }
}

//http://pt.stackoverflow.com/q/179966/101
