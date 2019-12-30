public class Experiencias_Trabalho {
    public Experiencias_Trabalho(string nomeEmpresa, string cargo, string descricaoFuncao, DateTime dataInicio, DateTime dataSaida) {
        NomeEmpresa = nomeEmpresa;
        Cargo = cargo;
        DescricaoFuncao = descricaoFuncao;
        DataInicio = dataInicio;
        DataSaida = dataSaida;
    }

    public string NomeEmpresa { get; set; }
    public string Cargo { get; set; }
    public string DescricaoFuncao { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataSaida { get; set; }

    public string TempoTotal() {
        var total = new DateTime().AddDays((int)(DataSaida - DataInicio).TotalDays);
        return (total.Year - 1) + " anos, " + (total.Month % 12) + " meses " + (total.Day % 365) + " dias.";
    }

    public string Imprimir_Experiencias_Trabalho() {
        return $@"<tr>
                      <td>{NomeEmpresa}</td>
                      <td>{Cargo}</td>
                      <td>{DescricaoFuncao}</td>
                      <td>{TempoTotal()}</td>
                      <td><i class='fa fa-edit'></i> <i class='fa fa-trash'></i></td>
                  </tr>";
    }
}

//https://pt.stackoverflow.com/q/124934/101
