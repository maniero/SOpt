using System;
using System.Dynamic;
 
class Dinamica : DynamicObject {
    public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result) {
        result = null;
         Console.WriteLine($"Executando método \"{binder.Name}\".");
        return true;
    }
}
 
public class Program {
    public static void Main(string[] args) {
        dynamic din = new Dinamica();
        din.NaoExiste();
    }
}

//https://pt.stackoverflow.com/q/137542/101
