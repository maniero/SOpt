HashMap<Integer, Float> aluno = new HashMap<Integer Float>();
  .
  .
  .
  //achei soma das notas
  Iterator<Integer> i = aluno.keySet().iterator();
  while(i.hasNext()){
      int chave = i.next();
      sumNotas+=aluno.get(chave);
  }

  //printei média
  //n é a quantidde de alunos
  System.out.println("média: " + sumNotas/n + "\n" + "Alunos acima da média:" + "\n");

  //quero printar se a nota do aluno é maior que a média, mas não funciona
  //n é a quantidde de alunos
  i = aluno.keySet().iterator(); //<============ adicionado aqui
  while(i.hasNext()){
    int chave = i.next();
    if(aluno.get(chave) > sumNotas/n)
        System.out.print(chave +  ", ");
    }
    
//https://pt.stackoverflow.com/q/41200/101
