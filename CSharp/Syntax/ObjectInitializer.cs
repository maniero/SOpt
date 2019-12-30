var cliente = new ClienteModel {
    id = Convert.ToInt32(Dr["id"]),
    codcli = Convert.ToInt32(Dr["codcli"]),
    nome = Dr["nome"],
    endereco = Dr["endereco"],
    nr = Dr["nr"],
    bairro =Dr["bairro"],
    cidade = Dr["cidade"],
    estado.id = 1,
    estado.sigla = Dr["sigla"]
};

//https://pt.stackoverflow.com/q/124832/101
