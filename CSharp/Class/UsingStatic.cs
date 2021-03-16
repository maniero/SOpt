using static Crypt.CaesarCipher;

public class Program {
    public static void Main() => Decode("", 0);
}

namespace Crypt {
    public static class CaesarCipher {
        public static string Decode(string text, byte key) => "";
        public static string Encode(string text, byte key) => "";
    }
}

//https://pt.stackoverflow.com/q/499060/101
