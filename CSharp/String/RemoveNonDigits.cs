using static System.Console;
using System.Text;

WriteLine(RemoveNonDigits("M1245D454"));

static string RemoveNonDigits(string text) {
    StringBuilder newText = new(text.Length);
    foreach (var c in text) if (!char.IsDigit(c)) newText.Append(c);
    return newText.ToString();      
}

//https://pt.stackoverflow.com/q/123453/101
