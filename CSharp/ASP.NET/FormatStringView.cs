public string TitleCaseNmFuncionario {
    get {
        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.NmFuncionario);
    }
}

@Model.TitleCaseNmFuncionario

@System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Model.NmFuncionario)

@{
    var textInfo = new System.Globalization.CultureInfo("en-US", false).TextInfo;
    this.Write(textInfo.ToTitleCase("war and peace"));
}

namespace Extensions {
    public static class StringExtensions {
        public static string ToTitleCase(this string texto, string cultura = "en-US") {
            if (string.IsNullOrWhiteSpace(cultura)) {
                cultura = "en-US";
            }
            var textInfo = new System.Globalization.CultureInfo(cultura, false).TextInfo;
            return textInfo.ToTitleCase(texto);
        }
    }
}

@Model.NmFuncionario.ToTitleCase()

<add namespace="Extensions" />

//https://pt.stackoverflow.com/q/49427/101
