public DateTime OrderDateDeli { get; } = DateTime.Today;

public DateTime OrderDateDeli {
    get => orderDateDeli;
    set {
        //faz aqui o tratamento necessário com o value para poder usar corretamente
    }
}

public DateTime OrderDateDeli { get; set; } = DateTime.Today;

//https://pt.stackoverflow.com/q/361995/101
