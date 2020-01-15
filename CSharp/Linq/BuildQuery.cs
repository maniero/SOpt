private void lerPessoa(string nome, bool maiorIdade) {
    using (BancoEFEntities context = new BancoEFEntities()) {
        var pessoa = context.Pessoa.Where(p => p.nome.Contains(nome));
        if (maiorIdade) pessoa = pessoa.Where(p => p.idade >= 18);
        dataGridViewPessoa.DataSource = pessoa.ToList();
    }
}

//https://pt.stackoverflow.com/q/130743/101
