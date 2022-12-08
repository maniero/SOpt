var text = "aaaaaaaaaa\"aaaaaaaaaaaaaaaaa\naaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\naaaaa\"aaaaaaaaaa\"aaaaaaaaaaaaa";
var open = false;
System.Text.StringBuilder newText = new();
foreach (var character in text) {
	if (character == '"' || (open && character == '\n')) {
		open = !open;
		newText.Append(character);
		continue;
	}
	newText.Append(open ? 'b' : character);
}
System.Console.WriteLine(newText);

//https://pt.stackoverflow.com/q/69376/101
