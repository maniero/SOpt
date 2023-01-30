DateOnly.FromDateTime(DateTime.Now)

public static class DateExt {
    public static DateOnly Now(this DateOnly dateTime) => DateOnly.FromDateTime(dateTime);
}

//https://pt.stackoverflow.com/q/575958/101
