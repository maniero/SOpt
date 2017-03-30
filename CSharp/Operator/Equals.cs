using static System.Console;
					
public class Program {
    public static void Main() {
        // cria duas variáveis iguais mas distintas uma da outra
        string a = new string(new char[] {'h', 'e', 'l', 'l', 'o'});
        string b = new string(new char[] {'h', 'e', 'l', 'l', 'o'});
        WriteLine (a == b);
        WriteLine (a.Equals(b));
        // o mesmo teste usando os mesmo dados mas como variáveis do tipo `Object`
        object c = a;
        object d = b;
        WriteLine (c == d);
        WriteLine (c.Equals(d));
		WriteLine("-----------------");
		int myInt = 1;
		short myShort = 1;
		object objInt1 = myInt;
		object objInt2 = myInt;
		object objShort = myShort;
		WriteLine(myInt == myShort);          // cenário 1 true
		WriteLine(myShort == myInt);          // cenário 2 true
		WriteLine(myInt.Equals(myShort));     // cenário 3 true
		WriteLine(myShort.Equals(myInt));     // cenário 4 false!
		WriteLine(objInt1 == objInt1);        // cenário 5 true
		WriteLine(objInt1 == objShort);       // cenário 6 false!!
		WriteLine(objInt1 == objInt2);        // cenário 7 false!!!
		WriteLine(Equals(objInt1, objInt2));  // cenário 8 true
		WriteLine(Equals(objInt1, objShort)); // cenário 9 false!?!
		WriteLine("-----------------");
		string s1 = "abc";
		string s2 = "abc";
		WriteLine(object.ReferenceEquals(s1, s2)); //retorna true
		string s3 = "abc";
		string s4t = "ab";
		string s4 = s4t + "c";
		WriteLine(object.ReferenceEquals(s3, s4)); //retorna false
		WriteLine(s3 == s4); //retorna true
    }
}

//http://pt.stackoverflow.com/q/18910/101
