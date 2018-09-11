public static string HashedString(string text) {
    var sha512 = new SHA512Managed();
    byte[] hash = sha512.ComputeHash(Encoding.UTF8.GetBytes(text));
    var result = new StringBuilder();
    foreach (byte b in hash) result.Append($"{b:x2}");
    return result.ToString();
}

//https://pt.stackoverflow.com/q/327973/101
