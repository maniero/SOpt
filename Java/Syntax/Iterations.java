for (Iterator<Pessoa> i = pegaListaPessoas().iterator(); i.hasNext(); i.next()) {

List<Pessoa> pessoas = pegaListaPessoas();
for (Iterator<Pessoa> i = pessoas.iterator(); i.hasNext(); i.next()) {

Iterator<Pessoa> i = pegaListaPessoas().iterator();
while (i.hasNext()){
     Pessoa p = i.next();
}

List<Pessoa> pessoas = pegaListaPessoas();
Iterator<Pessoa> i = pessoas.iterator();
while(i.hasNext()){
     Pessoa p = i.next();
}

//https://pt.stackoverflow.com/q/31922/101
