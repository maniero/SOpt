foreach (var item in pendenciaController.ListaContrato) {
    foreach (var pendencia in pendenciaController.ListaPendencia) {
        if (pendencia.Contrato.Equals(item.Content)) {
            item.IsEnabled = false;
            break;
        }
    }
}

//https://pt.stackoverflow.com/q/164659/101
