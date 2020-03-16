using System;
public class C {
    public static void Main() {
        int x = 0;
        try {
          x = 10;
          throw new Exception();
          x = 20;
        } catch (Exception) {
          x++;
          Console.WriteLine($"Valor de x: {x}");
        }
    }
}

//https://pt.stackoverflow.com/q/159266/101
