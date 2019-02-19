public static string Coalesce<T>(this T obj, string defaultValue = "") {
    if (obj == null) return defaultValue;
    return obj.ToString();
}

//https://pt.stackoverflow.com/q/45524/101
