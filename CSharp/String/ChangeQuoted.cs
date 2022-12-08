var text = "aaaaaaaaaa\"aaa\"aaaaaaaaaaaaaa\naaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\naaaaa\"aaaaaaaaaa\"aaaaaaaaaaaaa";
var open = false;
System.Text.StringBuilder newText = new();
foreach (var character in text) {
	if (character == '"') {
		open = !open;
		newText.Append('"');
		continue;
	}
	newText.Append(open ? 'b' : character);
}
System.Console.WriteLine(newText);

//https://pt.stackoverflow.com/q/69376/101
