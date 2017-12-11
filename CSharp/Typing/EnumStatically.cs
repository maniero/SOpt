using static System.Globalization.CharUnicodeInfo;
using  System.Globalization;

static class Validator {
	static void Main() {}
    static bool TestCategory(UnicodeCategory cat, char cp) => GetUnicodeCategory(cp) == cat;
}

//https://pt.stackoverflow.com/q/262203/101
