    public bool EhDiaValido(int dia, int mes, int ano) {
        return dia >= DateTime.MinValue && dia <= DateTime.DaysInMonth(ano, mes);
    }

    public bool EhDiaValido(string data) {
        DateTime resultado;
        return DateTime.TryParse(data, out resultado);
    }

No C# 7 o último método pode ser escrito como:

    public bool EhDiaValido(string data) {
        return DateTime.TryParse(data, out var resultado);
    }

//http://pt.stackoverflow.com/q/4776/101
