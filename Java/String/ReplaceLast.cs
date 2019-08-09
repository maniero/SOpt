public static String replaceLast(string text, string source, string target) {
    StringBuilder b = new StringBuilder(text);
    b.replace(text.lastIndexOf(source), text.lastIndexOf(source) + source.length(), target);
    return b.toString();
}

public static String replaceLast(String text, String regex, String replacement) {
    return text.replaceFirst("(?s)(.*)" + regex, "$1" + replacement);
}

//https://pt.stackoverflow.com/q/53512/101
