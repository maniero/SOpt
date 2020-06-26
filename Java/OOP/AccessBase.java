class Main {
	public static void main (String[] args) {
		var b = new B(5);
		System.out.println(b.getA());
	}
}
class A {
    private int a;

    A(int num) {
        a = num;
    }
    public int getA() {
        return a;
    }
}

class B extends A {
    B(int num) {
        super(num);
    }
    @Override
    public int getA() {
        return super.getA();
    }
}

//https://pt.stackoverflow.com/q/459423/101
