public void setEmpregados(Funcionario[] empregados) {
    this.empregados = empregados;
}

public void setEmpregados(int tamanho) {
    this.empregados = new Funcionario[tamanho];
}

public Funcionario getEmpregados(){
    return this.empregados;
}

public Empresa(int tamanho) {
    this(new Funcionario[tamanho]);
}

public Empresa(Funcionario[] empregados) {
    this.empregados = empregados;
}

private ArrayList<Funcionario> empregados = new ArrayList<Funcionario>();

//https://pt.stackoverflow.com/q/86738/101
