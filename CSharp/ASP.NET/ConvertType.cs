[DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:c}")]

bol.IRPJ = "IRPJ " + irpj + "%" + " - " + $"{bol.ValorBoleto * irpj / 100):c}";

//https://pt.stackoverflow.com/q/81237/101
