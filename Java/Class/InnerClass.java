public class InnerClassTest {
    public void foo() {
        System.out.println("Outer class");
    }

    public class ReallyInner {
        public void foo() {
            System.out.println("Inner class");
        }

        public void test() {
            this.foo();
            InnerClassTest.this.foo();
        }
    }

    public static void main(String[] args) {
        InnerClassTest o = new InnerClassTest();
        InnerClassTest.ReallyInner i = o.new ReallyInner();
        i.test();
    }
}

//https://pt.stackoverflow.com/q/37515/101
