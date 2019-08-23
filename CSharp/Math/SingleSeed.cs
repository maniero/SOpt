var rand = new Random();
for (int i = 0; i < itens.Count; i++) {
    if (itens[i].Novo) 
        var id = $"{DateTime.Now:yy}{DateTime.Now:MM}{DateTime.Now:dd}{DateTime.Now:hh}{DateTime.Now:ff}{rand.Next(10000, 99999)}";
        [...]
    }
}

//https://pt.stackoverflow.com/q/55701/101
