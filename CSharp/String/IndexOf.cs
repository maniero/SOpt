System.Console.WriteLine(IndexOf("Olá planeta terra, você é um grande planeta", 'e', 9));

int IndexOf(string haystack, char needle, int offset) {
	for (int i = offset; i < haystack.Length; i++) if (haystack[i] == needle) return i;
	return -1;
}

//https://pt.stackoverflow.com/q/567447/101
