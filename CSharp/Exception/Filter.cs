try {
    context.Produto.Add(_produto);
    context.SaveChanges();
} catch (UpdateException ex) when (innerException?.Number == 2627) {
    //tratar erro de chave duplicada
} catch(exceção 2) {
    // tratar erro diferente de chave duplicada
}

//https://pt.stackoverflow.com/q/90207/101
