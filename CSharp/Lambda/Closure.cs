using System;
 
class Program {
    static void Main() {
        (Action c1, Action c2) = Test();
        c1();
        c1();
		c2();
		c2();
    }
    static (Action, Action) Test() {
        int c1 = 0;
		int c2 = 0;
        return (() => Console.WriteLine(c1++), () => Console.WriteLine(c2++));
    }
}
 
//https://pt.stackoverflow.com/q/580366/101
