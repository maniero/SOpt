using System;
using static System.Console;
using System.Collections.Generic;

public class Pessoa {
    public string Nome { get; set; } = "";
    public string Endereco { get; set; } = "";
    public int Idade { get; set; } = 0;
    public string Cargo { get; set; } = "";
    public decimal Salario { get; set; } = 0M;
}
public class ModelPessoa : Model<Pessoa> { //adotei a ideia que o Model seria para validar mesmo.
    override public bool Validate() {
        Required("Nome", Value.Nome);
        ValidaEndereco();
        Required("Cargo", Value.Cargo);
        Custom("Salário", "SalarioValido", "O Salário não atende os requisitos", ValidaSalario);
		Range("Idade", Value.Idade, Util.GetMaioridade(), 120);
        return (IsValid = Errors.Count == 0);
    }
	public int AsIdade(string texto) { //isto não é tão necessário, mas quis mostrar esta possibilidade
		var idade = 0;
		if (int.TryParse(texto, out idade)) {
		    return idade;
		} else {
			Errors["IdadeInconsistente"] = new Invalidation("Idade", "A Idade foi digitada de forma inconsistente");
			return 0;
		}
	}
	public decimal AsSalario(string texto) { //isto funciona como uma abstração/encapsulamento da funcionalidade
		var salario = 0M;
		if (decimal.TryParse(texto, out salario)) {
		    return salario;
		} else {
			Errors["SalarioInconsistente"] = new Invalidation("Salario", "O Salário foi digitado de forma inconsistente");
			return 0;
		}
	}
	private void ValidaEndereco() { //tem a vantagem de que pode mudar a regra facilmente tendo um método isolando a funcionalidade
		if (!Util.IsStandardAddress(Value.Endereco)) {
 			AddError("EnderecoPadrao", "Endereço", "EnderecoPadrao", "O Endereço está em formato inválido.");
		}
	}
	private bool ValidaSalario(object[] values) { //feito para operar com o Custom, pode mudar as regras fácil aqui de forma canônica
		return ((!Errors.ContainsKey("IdadeInconsistente") && Value.Idade > 21 && Value.Salario > 1000M)) ||
			(Value.Cargo != "Gerente" && Value.Salario > 900M) ||
			(Value.Cargo == "Gerente" && Value.Salario > 1200M);
	}
}
public static class Util { //esta classe foi só para agrupar, em código real estes métodos estariam em outras classes
	public static string Read(string label) {
		Write(label);
        return ReadLine();
	}
	public static int GetMaioridade() => 18; //aqui poderia estar pegando de um banco de dados ou arquivo de configuração
	public static bool IsStandardAddress(string address) => address.Length > 2 && (address.Substring(0, 3) == "Rua" || address.Substring(0, 3) == "Av.");
}
public class Program {
    public static void Main(string[] args) {
		while (true) {
			var mp = new ModelPessoa(); //o modelo é usado para trabalhar com dados temporários
			mp.Messages["Idade"] = "A pessoa precisa ser maior de idade"; //personalizando uma mensagem
			mp.Value.Nome = Util.Read("Nome: "); //lê o dado e guarda no modelo
			mp.Value.Endereco = Util.Read("Endereço: ");
			mp.Value.Idade = mp.AsIdade(Util.Read("Idade: ")); //tentando converter
			mp.Value.Cargo = Util.Read("Cargo: ");
			mp.Value.Salario = mp.AsSalario(Util.Read("Salário: "));
			if (mp.Validate()) {
				Pessoa funcionario = mp.Value; //se está válido, então pode jogar em um objeto definitivo, gravar em DB, etc
				WriteLine("Cadastro efetuado!");
				break;
			} else {
				WriteLine("Erros ocorreram!");
				foreach(var erro in mp.Errors) { //tem várias formas para mostrar os erros
					WriteLine(erro.Value);
				}
			}
		}
    }
}
public class Invalidation { //uma classe simplificada para guardar dados completos sobre uma invalidade, parecido com exceção, sem ser
	public string Data { get; private set; }
	private string message;
	public string Message {
		get => message ?? "Dado inválido";
	}
	public Invalidation(string data, string message = null) {
		Data = data;
		this.message = message;
	}
	public override string ToString() => Message;
}
public abstract class Model<T> where T : new() { //mecanismo básico de validação separado do modelo em si. Tem maneiras mais simples de fazer o controle de erros
	public T Value { get; private set; } = new T();
	public bool IsValid { get; protected set; } = false;
    public Dictionary<string, Invalidation> Errors { get; protected set; } = new Dictionary<string, Invalidation>();
    public Dictionary<string, string> Messages { get; set; } = new Dictionary<string, string>();
    public abstract bool Validate();
	protected void Required(string field, string value) { //alguns exemplos de códigos genéricos de validação
		if (string.IsNullOrEmpty(value)) AddError(field + "Required", field, "Required", "O campo {0} é obrigatório.");
    }
    protected void Range(string field, int value, int min, int max) {
		if (value < min || value > max) AddError(field + "Range", field, "Range", "O campo {0} deve estar na faixa de {1} até {2}.", min, max);
    }
	protected void Custom(string field, string messageKey, string messageAlt, Func<object[], bool> condition, params object[] values) {
		if (!condition(values)) {
			if (values != null && values.Length > 0) {
 				AddError(field + messageKey, field, messageKey, messageAlt, values?[0], values?[1], values?[2]); //está porco, mas não vou gastar tempo
			} else {
 				AddError(field + messageKey, field, messageKey, messageAlt);
			}
		}
    }
	protected void AddError(string errorKey, string field, string messageKey, string defaultMessage, object value1 = null, object value2 = null, object value3 = null) {
		var message = "";
		Errors[errorKey] = new Invalidation(field, string.Format(Messages.TryGetValue(messageKey, out message) ? message : defaultMessage, field, value1, value2, value3));
	}
}

//https://pt.stackoverflow.com/q/105670/101
