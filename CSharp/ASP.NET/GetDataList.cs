public ActionResult errosPorTema(int idAluno) {
    Aluno a = alunoModel.obterAluno(idAluno);
    List<Tema> temas = alunoAtividadeModel.listarTemasPorAluno(idAluno);
    var listaErradasTema = new List<ErradaTema>();
    for (int i = 0; i < temas.Count; i++) {
        listaErradasTema.Add(new ErradaTema() {
            Tema = temas[i].Descricao,
            QtdeErradas = alunoAtividadeModel.listarPerguntasErradasPorTema2(a.idAluno, temas[i].idTema)
        });
    }
    return View(listaErradasTema);
}

//https://pt.stackoverflow.com/q/92205/101
