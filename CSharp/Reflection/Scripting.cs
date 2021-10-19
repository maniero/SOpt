using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CodeAnalysis.Scripting.CSharp;

namespace RoslynScriptingDemo {
    class Program {
        static void Main(string[] args) {
            var engine = new ScriptEngine();
            engine.Execute(@"System.Console.WriteLine(""Hello Roslyn"");");
        }
    }
}

//Outro exemplo um pouco mais complexo:

using System;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CodeAnalysis.Scripting.CSharp;

namespace Test.ConsoleApp {
    public class Program {
        static void Main(string[] args) {
            var engine = new ScriptEngine();

            var session = engine.CreateSession();

            session.AddReference("System");
            session.AddReference("System.Linq");

            session.Execute(@"using System;
                              var arr = new[] {1, 2, 6};
                              foreach (var i in arr) {
                                  if(i > 1) { Console.WriteLine(i); }
                              }"
                           );

            session.Execute(@"using System;
                              using System.Linq;
                              var arr = new[] {1, 2, 6};
                              var arrResult = arr.Where(x => x > 1);
                              foreach (var i in arrResult) {
                                  Console.WriteLine(i);
                              }"
                           );

            Console.ReadLine();
        }
    }
}

//http://pt.stackoverflow.com/q/15428/101
