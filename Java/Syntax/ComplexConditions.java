List<Pessoa> resultadoPesquisa = pessoas.stream()
              .filter(pessoa ->
                  pessoa.getIdade() >= 18 &&
                  pessoa.getGenero().equals("Feminino"))
              .collect(Collectors.toList());

List<Pessoa> resultadoPesquisa = pessoas.stream()
              .filter(pessoa ->
                  ÉMaior(pessoa) &&
                  ÉFeminino(pessoa))
              .collect(Collectors.toList());
              
//https://pt.stackoverflow.com/q/115733/101
