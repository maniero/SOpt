public T Teste<T>(T pessoa) where T : Pessoa {
    //faz o que deseja aqui
    return pessoa;
}

var func = new Funcionario();
func = Teste(func); //ele infere, se não fosse possível chamaria Teste<Funcionario>(func)

//https://pt.stackoverflow.com/q/137406/101
