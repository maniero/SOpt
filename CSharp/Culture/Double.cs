Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

double.TryParse(valor, NumberStyles.Any, CultureInfo.InvariantCulture, out valorDouble)

Convert.ToDouble(valor, CultureInfo.InvariantCulture)

//https://pt.stackoverflow.com/q/21291/101
