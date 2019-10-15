p => p.Tipo.Equals("S", StringComparison.InvariantCultureIgnoreCase) &&
     p.Modo.Equals("S", StringComparison.InvariantCultureIgnoreCase)...,n

p => p.Tipo.ToUpper() == "S" && p.Modo.ToUpper() == "S"...,n

//https://pt.stackoverflow.com/q/90851/101
