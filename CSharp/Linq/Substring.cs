for (int i = 0; i < lista.Count; i++) if (s.Length > 3) lista[i] = lista[i].Substring(3);
lista = lista.Select(s => s.Length > 3 ? s.Substring(3) : s).ToList();

//https://pt.stackoverflow.com/q/361903/101
