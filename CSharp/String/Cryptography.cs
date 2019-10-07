using static System.Console;
using System.Security.Cryptography;
using System.Text;
					
public class Program {
	public static void Main() => WriteLine(sha512("senha qualquer"));
	 
	static string sha512(string password) {
        byte[] bytes = new SHA512Managed().ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
        var hash = new StringBuilder();
        foreach (var item in bytes) hash.Append(item.ToString("x2"));
        return hash.ToString();
    }
}

//https://pt.stackoverflow.com/q/87329/101
