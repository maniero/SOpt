using static System.Console;
using static System.Convert;
using System.Text;
					
WriteLine(WrapString("0123456789012345678901234567890123456789", 10));
WriteLine(WrapString("01234567890123456", 10));
WriteLine(WrapString("012345", 10));

static string WrapString(string text, int len) {
	if (text.Length <= len) return text;
	StringBuilder sb = new(text.Length + text.Length / len * 2);
	var i = 0;
	for (; i < text.Length / 10; i++) {
		sb.Append(text[(i * 10)..(i * 10 + 10)]);
		sb.Append("\r\n");
	}
	if (text.Length / 10 != ToSingle(text.Length) / 10) {
		sb.Append(text[(i * 10)..]);
		sb.Append("\r\n");
	} else sb.Remove(sb.Length - 2, 2);
	return sb.ToString();
}

//https://pt.stackoverflow.com/q/228864/101
