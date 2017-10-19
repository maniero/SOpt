public static string ReplaceString(string str, string oldValue, string newValue, StringComparison comparison = StringComparison.CurrentCultureIgnoreCase) {
    StringBuilder sb = new StringBuilder();
    int previousIndex = 0;
    int index = str.IndexOf(oldValue, comparison);
    while (index != -1) {
        sb.Append(str.Substring(previousIndex, index - previousIndex));
        sb.Append(newValue);
        index += oldValue.Length;
        previousIndex = index;
        index = str.IndexOf(oldValue, index, comparison);
    }
    sb.Append(str.Substring(previousIndex));
    return sb.ToString();
}

//https://pt.stackoverflow.com/q/32245/101
