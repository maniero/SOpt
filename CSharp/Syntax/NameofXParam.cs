public static void Relatorio(Trem trem, string nome) {
    WriteLine($"{nome} - PESO ATUAL:       {trem.getPesoVagao()}");

Trem.Relatorio(T2, "T2");

Trem.Relatorio(T2, nameof(T2));

//https://pt.stackoverflow.com/q/333288/101
