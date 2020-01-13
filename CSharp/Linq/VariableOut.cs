foreach (var c in Lista()) {
    if (c.Validade > DateTIme.Now) {
        //faz alguma coisa
    }
    //talvez chama algo aqui demorado
}

var agora = DateTIme.Now;
foreach (var c in Lista()) {
    if (c.Validade > agora) {
        //faz alguma coisa, poderia ser montar uma outra lista, mas seria a materialização
    }
    //talvez chama algo aqui demorado
}

//https://pt.stackoverflow.com/q/430376/101
