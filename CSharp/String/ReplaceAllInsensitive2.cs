public static class StringExtensions {
    public static string Replace(this string originalString, string oldValue, string newValue, StringComparison comparisonType) {
        int startIndex = 0;
        while (true) {
            startIndex = originalString.IndexOf(oldValue, startIndex, comparisonType);
            if (startIndex == -1)
                break;
            originalString = originalString.Substring(0, startIndex) + newValue + originalString.Substring(startIndex + oldValue.Length);
            startIndex += newValue.Length;
        }
        return originalString;
    }
}

//https://pt.stackoverflow.com/q/32245/101
