using System.Collections.Generic;
					
public class Program {
	public static void Main() {}
}

class descricaoo : IInstrucao {
    private string descricaobol;
    public descricaoo (int ibanco, int codigo, string descricaobol, int qtde) {
        this.descricaobol = descricaobol;
        List<IInstrucao> desci = new List<IInstrucao> { new descricaoo(ibanco,codigo,descricaobol,qtde) };
    }
    public IBanco Banco { get; set; }
    public int Codigo { get; set; }
    public string Descricao { get; set; }
    public int QuantidadeDias { get; set; }
}

public interface IInstrucao {
    IBanco Banco { get; set; }
    int Codigo { get; set; }
    string Descricao { get; set; }
    int QuantidadeDias { get; set; }
}

public interface IBanco {}

//https://pt.stackoverflow.com/q/95363/101
