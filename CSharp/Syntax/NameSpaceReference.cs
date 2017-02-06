namespace Estoque {
    public class FormCadastro { ... }
}

Na verdade internamente é criado:

public class Estoque.FormCadastro { ... }

//Referência no projeto

<References>
  <Reference
    Name = "Lib1"
    AssemblyName = "Lib1"
    HintPath = "\\BuildServer\Latest\Release\SharedComponent\SomeControl.dll"
  />
</References>

//http://pt.stackoverflow.com/q/11199/101
