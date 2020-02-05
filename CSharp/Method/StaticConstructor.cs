public class Exemplo {
    static int x = 1;
}
No fundo será gerado algo assim:

public class Exemplo {
    static int x;
    static Exemplo() { x = 1; }
}
Código IL gerado para o código da pergunta (note a existência de dois ctor, um normal e outro de instância e note o beforefieldinit):

.class private auto ansi '<Module>'
{
} // end of class <Module>

.class public auto ansi beforefieldinit Program
    extends [mscorlib]System.Object
{
    // Methods
    .method public hidebysig static 
        void Main () cil managed 
    {
        // Method begins at RVA 0x2050
        // Code size 32 (0x20)
        .maxstack 2
        .locals init (
            [0] class MinhaClasse
        )

        IL_0000: nop
        IL_0001: newobj instance void MinhaClasse::.ctor() //   <========= note a chamada ao método de instância
        IL_0006: stloc.0
        IL_0007: ldloc.0
        IL_0008: ldstr "Hello Stackoverflow"
        IL_000d: callvirt instance void MinhaClasse::set_Propriedade(string)
        IL_0012: nop
        IL_0013: ldloc.0
        IL_0014: callvirt instance string MinhaClasse::get_Propriedade()
        IL_0019: call void [mscorlib]System.Console::WriteLine(string)
        IL_001e: nop
        IL_001f: ret
    } // end of method Program::Main

    .method public hidebysig specialname rtspecialname 
        instance void .ctor () cil managed 
    {
        // Method begins at RVA 0x207c
        // Code size 8 (0x8)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: call instance void [mscorlib]System.Object::.ctor()
        IL_0006: nop
        IL_0007: ret
    } // end of method Program::.ctor

} // end of class Program

.class public auto ansi MinhaClasse
    extends [mscorlib]System.Object
{
    // Fields
    .field private string '<Propriedade>k__BackingField'
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
        01 00 00 00
    )
    .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggerBrowsableState) = (
        01 00 00 00 00 00 00 00
    )

    // Methods
    .method public hidebysig specialname 
        instance string get_Propriedade () cil managed 
    {
        .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
            01 00 00 00
        )
        // Method begins at RVA 0x2085
        // Code size 7 (0x7)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: ldfld string MinhaClasse::'<Propriedade>k__BackingField'
        IL_0006: ret
    } // end of method MinhaClasse::get_Propriedade

    .method public hidebysig specialname 
        instance void set_Propriedade (
            string 'value'
        ) cil managed 
    {
        .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
            01 00 00 00
        )
        // Method begins at RVA 0x208d
        // Code size 8 (0x8)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: ldarg.1
        IL_0002: stfld string MinhaClasse::'<Propriedade>k__BackingField'
        IL_0007: ret
    } // end of method MinhaClasse::set_Propriedade

    .method private hidebysig specialname rtspecialname static  
        void .cctor () cil managed   //<============== construtor estático aqui
    {
        // Method begins at RVA 0x2096
        // Code size 2 (0x2)
        .maxstack 8

        IL_0000: nop
        IL_0001: ret
    } // end of method MinhaClasse::.cctor

    .method public hidebysig specialname rtspecialname 
        instance void .ctor () cil managed   //<============== construtor de instância aqui
    {
        // Method begins at RVA 0x207c
        // Code size 8 (0x8)
        .maxstack 8

        IL_0000: ldarg.0
        IL_0001: call instance void [mscorlib]System.Object::.ctor()
        IL_0006: nop
        IL_0007: ret
    } // end of method MinhaClasse::.ctor

    // Properties
    .property instance string Propriedade()
    {
        .get instance string MinhaClasse::get_Propriedade()
        .set instance void MinhaClasse::set_Propriedade(string)
    }

} // end of class MinhaClasse

//https://pt.stackoverflow.com/q/138554/101
