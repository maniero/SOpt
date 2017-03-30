Pessoa *p = new Pessoa("Ronald Araújo", "ronald.araujo@live.com", 23);

 QMessageBox msg;
 msg.setText(QString::fromStdString(p->getNome()));
 msg.exec();

Segunda solução:

Mude a definição de Pessoa.

QString Pessoa::getNome() { return this->nome; }

Desde que, é claro, mude o Pessoa::nome para QString também.

Normalmente uma aplicação feita para a Qt é preferível usar os tipos da Qt. Claro que há situações que isto não é possível, daí a primeira solução é a ideal.

Aí você poderá usar:

 Pessoa *p = new Pessoa("Ronald Araújo", "ronald.araujo@live.com", 23);

 QMessageBox msg;
 msg.setText(p->getNome());
 msg.exec();

Evidentemente que nesta solução, você vai ter que garantir que tenha uma sobrecarga do construtor que faça a conversão de std::string para QString. Algo como:

Pessoa(string nome, string email, int idade) {
    this.nome = nomeQString::fromStdString(nome);
    this.email = nomeQString::fromStdString(email);
    this.idade = idade;
}

//http://pt.stackoverflow.com/q/21700/101
