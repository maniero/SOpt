class Exemplo {
    public int valor { get; set; } = 1;
}

//No fundo é o mesmo que

internal class Exemplo {
    private int valor;
    public int Valor {
        get { return valor; }
        set { valor = value; }
    }
    public Exemplo() {
        valor = 1;
    }
}

.class private auto ansi beforefieldinit AutoPropertyInitializer.Exemplo
       extends [mscorlib]System.Object {
  .field private int32 '<Property>k__Valor'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname instance int32 
          get_Valor() cil managed {
              //corpo aqui
          }

  .method public hidebysig specialname instance void
          set_Valor(int32 'value') cil managed {
              //corpo aqui
          }

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed {
              // Code size       18 (0x12)
              .maxstack  8
              IL_0000:  ldarg.0
              IL_0001:  ldc.i4     0x1
              IL_0006:  stfld      int32 AutoPropertyInitializer.Exemplo::'<Property>k__Valor'
              IL_000b:  ldarg.0
              IL_000c:  call       instance void [mscorlib]System.Object::.ctor()
              IL_0011:  ret
          }

    .property instance int32 Valor() {
        .get instance int32 AutoPropertyInitializer.Exemplo::get_Valor()
        .set instance void AutoPropertyInitializer.Exemplo::set_Valor(int32)
    }
}

//https://pt.stackoverflow.com/q/108516/101
