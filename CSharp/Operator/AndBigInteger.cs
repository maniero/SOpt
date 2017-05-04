using static System.Console;
using System.Numerics;

public class Program {
	public static void Main() {
		WriteLine(VerificaPermissao((BigInteger)1, (BigInteger)0));
		WriteLine(VerificaPermissao((BigInteger)1, (BigInteger)1));
	}
	public static bool VerificaPermissao(BigInteger perm1, BigInteger perm) {
        if (perm1 == null || perm == null || (perm1.IsZero) || (perm.IsZero ))
            return false;
        return (perm & perm1) != 0;
    }

}

//https://pt.stackoverflow.com/q/202352/101
