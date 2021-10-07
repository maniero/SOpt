//Sem SESE:

void funcao1() {
  resource recurso = acquire_resource();  //talvez possa ser um malloc() aqui
  if( funcao2(recurso) )
    return; // esqueceu do código de liberação antes do return e o recurso vazou
  .
  .
  .
  funcao3(recurso);
  release_resource(recurso);  //poderia ser um free()
  return;
}

//Com SESE:

void funcao1() {
  resource recurso = acquire_resource();  //talvez possa ser um malloc() aqui
  if( funcao2(recurso) )
    goto saida; // manda para o ponto onde o recurso é liberado e termina a função
  .
  .
  .
  funcao3(recurso);
saida:
  release_resource(recurso);  //poderia ser um free()
  return;
}

//http://pt.stackoverflow.com/a/2478/101
