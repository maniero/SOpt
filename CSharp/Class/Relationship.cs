public class Mae {
   public string Nome {get; set;}
   public List<Filho> Filhos {get; set;} = new List<Filho>(); //C# 6
}
public class Filho {
   public string Nome {get; set;}
   public Mae Mae {get; set;}
}

Tem como criar algumas abstrações. Você pode criar construtores ou outros métodos auxiliares que automatizam um pouco o processo. Se todo filho tem que ter uma mãe, pode garantir isto no construtor e pode inclusive já fazer a inclusão do filho na mãe.

public class Filho {
   public Filho(String nome, Mae mae) {
       Nome = nome;
       Mae = mae;
       mae.Filho.Add(this);
   }
   public string Nome {get; set;}
   public Mae Mae {get; set;}
}

var filho = new Filho("João", mae);

//https://pt.stackoverflow.com/q/97119/101
