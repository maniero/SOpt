private string[] ObterValoresPropriedades(object objeto) {
   var val = new List<string>();
   foreach (var item in objeto.GetType().GetProperties())
       val.Add((item.GetValue(objeto) ?? "").ToString());
   return val.ToArray();
}

//https://pt.stackoverflow.com/q/44846/101
