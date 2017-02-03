int value;
try {
    value = int.Parse("!123x6");
} catch(FormatException) {
    value = -1; //solução horrível mas serve para o exemplo
}

//e

int value;
if (!int.TryParse("!123x6", out value)) {
    value = -1; //solução horrível mas serve para o exemplo
}

//A segunda forma me parece mais limpa. E em C# 7 ainda pode ser mais curto:

if (!int.TryParse("!123x6", out var value)) {
    value = -1;
}

//http://pt.stackoverflow.com/q/16089/101
