using System;
					
public class Program { public static void Main() {} }

public class Pessoa : ICloneable {
    public string Nome;
    public Pessoa Conjuge;
    public object Clone() {
        var p = new Pessoa();
        p.Nome = Nome;
	    if (Conjuge != null) p.Conjuge = (Pessoa)Conjuge.Clone();
        return p;
    }
}

public class Pessoa2 : ICloneable {
    public string Nome;
    public Pessoa2 Conjuge;
    public object Clone() => MemberwiseClone();
}

//https://pt.stackoverflow.com/q/156883/101
