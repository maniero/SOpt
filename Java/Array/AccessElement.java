public Aluno[] exibirCadastrados() {
    Aluno[] alunosCadastrados = new Aluno[100];
    for (int i = 0; i < listaAluno.length; i++) {
        if (listaAluno[i] != null) {
            alunosCadastrados[i] = listaAluno[i];
            System.out.println(alunosCadastrados[i]);
        }
    }
    return alunosCadastrados;
}

//https://pt.stackoverflow.com/q/367317/101
