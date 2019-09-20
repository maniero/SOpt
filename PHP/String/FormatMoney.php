$formatter = numfmt_create('pt_BR', NumberFormatter::CURRENCY);
var_dump(numfmt_parse_currency($formatter, "R$ 5.000,00", "BRL"));

//https://pt.stackoverflow.com/q/79898/101
