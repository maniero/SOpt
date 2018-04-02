using System;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        var trade = new Trading();
        trade.Trades.Add(new Trade() {Tid = 1, Date = DateTime.Now, Price = 100M, Amount = 10M, Type = "um"});
        trade.Trades.Add(new Trade() { Tid = 2, Date = DateTime.Now, Price = 200M, Amount = 20M, Type = "dois"});
    }
}

public interface ITrade {
    DateTime Date { get; set; }
    decimal Price { get; set; }
    decimal Amount { get; set; }
    string Type { get; set; }
}

interface ITrades {
    List<ITrade> Trades { get; set; }
}

public class Trade : ITrade {
    public int Tid { get; set; }
    public DateTime Date { get; set; }
    public decimal Price { get; set; }
    public decimal Amount { get; set; }
    public string Type { get; set; }
}

public class Trading {
    public List<ITrade> Trades { get; set; } = new List<ITrade>();
}

//https://pt.stackoverflow.com/q/288048/101
