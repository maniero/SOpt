public static int Parse(string s)
{
    return System.Number.ParseInt32(s, NumberStyles.Integer, NumberFormatInfo.CurrentInfo);
}

internal static unsafe int ParseInt32(string s, NumberStyles style, NumberFormatInfo info)
{
    byte* stackBuffer = stackalloc byte[1 * 0x72];
    NumberBuffer number = new NumberBuffer(stackBuffer);
    int num = 0;
    StringToNumber(s, style, ref number, info, false);
    if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
    {
        if (!HexNumberToInt32(ref number, ref num))
        {
            throw new OverflowException(Environment.GetResourceString("Overflow_Int32"));
        }
        return num;
    }
    if (!NumberToInt32(ref number, ref num))
    {
        throw new OverflowException(Environment.GetResourceString("Overflow_Int32"));
    }
    return num;
}

public static int ToInt32(string value)
{
    if (value == null)
    {
        return 0;
    }
    return int.Parse(value, CultureInfo.CurrentCulture);
}

//https://pt.stackoverflow.com/q/90981/101
