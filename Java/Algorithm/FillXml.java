private void FillElements(Node no, String nomeNo, String valor) {
    Element elemPessoa = (Element)no;
    Iterator<Element> iterador = elemPessoa.elementIterator(nomeNo);
    while (iterador.hasNext()) { 
        Element elemento = (Element)iterador.next();
        elemento.setText(valor);
    }
}
Usando:

FillElements(no, "idpessoa", String.valueOf(idPessoa)) //preenche as lacunas
FillElements(no, "nome", nome)
FillElements(no, "email", email)
FillElements(no, "celular", celular)

//https://pt.stackoverflow.com/q/152154/101
