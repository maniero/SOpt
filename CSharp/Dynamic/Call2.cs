using System;
using System.Dynamic;
using System.Reflection;
using System.Collections.Generic;
using static System.Console;

public class Dynamic : DynamicObject {
    Dictionary<string, object> dictionary = new Dictionary<string, object>();

    public override bool TryGetMember(GetMemberBinder binder, out object result) => dictionary.TryGetValue(binder.Name, out result);

    public override bool TrySetMember(SetMemberBinder binder, object value) {
        dictionary[binder.Name] = value;
        return true;
    }

    public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result) {
		if (dictionary.ContainsKey(binder.Name)) {
			((Action)dictionary[binder.Name]).Invoke(); //fiz gambi, precisa elaborar mais esta chamada para adequadar para qualquer tipo
			result = "Método dinâmico executou";
			return true;
		}
        try {
            result = (typeof(Dictionary<string, object>)).InvokeMember(binder.Name, BindingFlags.InvokeMethod, null, dictionary, args);
        } catch {
			result = "Resultado falho";
			WriteLine($"Executando método \"{binder.Name}\".");
        }
		return true;
    }

    public void Print() {
		foreach (var pair in dictionary) {
			if (!(pair.Value is Delegate)) WriteLine(pair.Key + " " + pair.Value);
		}
		if (dictionary.Count == 0) WriteLine("Sem membros para listar");
    }
}

public class Program {
    public static void Main(string[] args) {
        dynamic din = new Dynamic(); //precisa ser dynamic para o compilador não reclamar dos membros dinâmicos
        din.Nome = "Walla"; //criando membros dinamicamente
        din.Sobrenome = "C#";
		din.Action = new Action(() => WriteLine("Action Existe")); //isto não era necessário
        din.Print(); //chama um método existente na classe
		din.Action(); //chama o método que acabou de ser criado
        din.Clear(); //chama um método disponível no dicionário interno, mas que não está definido na classe
        din.Print(); //tá limpo
        din.NaoExiste(); //este método não existe
		dynamic exp = new ExpandoObject();
		exp.Action = new Action(() => WriteLine("Expando")); //só para mostrar que é possível fazer de forma automática, mas precisaria pesquisar
		exp.Action();
    }
}

//https://pt.stackoverflow.com/q/137542/101
