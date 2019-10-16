public class PessoaViewModel {
    public Pessoa Pessoa {get; set;}
    public Contato Contato {get; set;}
}

return View(new PessoaViewModel {Pessoa = dadosPessoa , Contato = dadosContato});

//https://pt.stackoverflow.com/q/91021/101
