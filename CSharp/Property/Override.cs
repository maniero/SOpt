public class ClienteViewModel {
    [Required(ErrorMessage = "Preencha o {0} do Cliente")]
    public virtual string Celular { get; set; } 
}

public class ClientePersonalizadoViewModel : ClienteViewModel {
    [DisplayFormat(ConvertEmptyStringToNull = false)]
    public override string Celular { get; set; }
}

//https://pt.stackoverflow.com/q/418619/101
