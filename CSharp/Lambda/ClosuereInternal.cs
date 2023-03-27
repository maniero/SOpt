using System;
 
class Program {
    static void Main() {
        Action closure = Test();
        closure();
        closure();
    }
    static Action Test() {
        Closure local = new Closure();
        local.counter = 0;
        return local.Function;
    }
}
//gerado pelo compilador
class Closure {
    public int counter;
    public void Function() => Console.WriteLine(counter++);
}
 
//https://pt.stackoverflow.com/q/580366/101
