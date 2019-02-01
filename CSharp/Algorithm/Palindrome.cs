using static System.Console;
					
public class Program {
	public static void Main() {
		WriteLine(checkPalindrome("ana"));
		WriteLine(checkPalindrome("abba"));
		WriteLine(checkPalindrome("oki"));
	}
	static bool checkPalindrome(string inputString) {
        if(inputString.Length >= 1 && inputString.Length <= 100000) {
            for (var i = 0; i < inputString.Length / 2; i++) if (char.ToLower(inputString[i]) != char.ToLower(inputString[inputString.Length - i - 1])) return false;
			return true;
		}
		return false;
	}
}

//https://pt.stackoverflow.com/q/359775/101
