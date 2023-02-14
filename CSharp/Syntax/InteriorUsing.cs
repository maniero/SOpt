using Biblioteca;
namespace A.B {
    class X
         int x = Classe.Meth();
    }
}
Considere que existe isto também:

namespace A {
    class Classe {
         public int Meth() => 1;
    }
}
E

namespace Biblioteca {
    class Classe {
         public int Meth() => 2;
    }
}
Quanto você acha que x valerá?

Valerá 1 porque o namespace tem prioridade, então é a classe dele que será usado.

E agora colocando o using dentro:

namespace A.B {
    using Biblioteca;
    class X
         int x = Classe.Meth();
    }
}

//https://pt.stackoverflow.com/q/577115/101
