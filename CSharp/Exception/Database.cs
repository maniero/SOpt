public bool IncluirRegistro(Pessoa tEntEF) {
    try {
        db.Pessoa.Add(tEntEF);
        int DadosSalvos = ;
        return (db.SaveChanges() > 0);
    } catch (DbUpdateException e) {
        return false;
    }
}

//https://pt.stackoverflow.com/q/254184/101
