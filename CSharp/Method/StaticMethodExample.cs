public static string TextNoFormatting(MaskedTextBox _mask) {
    _mask.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
    String retString = _mask.Text;
    _mask.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
    return retString;
}

//https://pt.stackoverflow.com/q/41564/101
