using System;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        var dicionario = new Dictionary<string, MyObject> {
            ["item1"] = new MyObject("item1", "valor1", 1, 1.1),
            ["item2"] = new MyObject("item2", "valor2", 2, 2.2),
            ["item3"] = new MyObject("item3", "valor3", 3, 3.3)
        };
        Console.WriteLine(dicionario["item2"].Value);
    }
}

public class MyObject {
    public string Name {get; set;}
    public string Value {get; set;}
    public int Prop1 {get; set;}
    public double Prop2 {get; set;}

    public MyObject (string name, string valueParam, int prop1, double prop2){
        this.Name = name;
        this.Value = valueParam;
        this.Prop1 = prop1;
        this.Prop2 = prop2;
    }
}

//https://pt.stackoverflow.com/q/257902/101
