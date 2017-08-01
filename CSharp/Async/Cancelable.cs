CancellationTokenSource cts;

private async void Button_Click() {
    cts = new CancellationTokenSource();
    try {
        await DoFoo(cts.Token);
    } catch (OperationCanceledException ex) {
        //trata o cancelamento
    }
}

private async void Cancelar_Click() => cts.Cancel();

private async Task DoFoo(CancellationToken ct) {
    // operações de I/O
    File.WriteAllText("path", "conteudo");
    for (var item in lista) {
        //faz o que quiser aqui
        ct.ThrowIfCancellationRequested(); //isto pode ser muito lento
    }
}

//https://pt.stackoverflow.com/q/224837/101
