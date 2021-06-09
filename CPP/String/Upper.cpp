for (auto &letra: nome) letra = toupper(letra);

transform(nome.begin(), nome.end(), nome.begin(), ::toupper);

//https://pt.stackoverflow.com/q/513449/101
