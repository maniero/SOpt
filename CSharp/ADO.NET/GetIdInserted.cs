cmd.CommandText = "INSERT INTO Venda(ID_Pessoa, ID_Caixa, ID_PDV, ID_Deposito, Data,
     Itens, Valor, Desconto, Valor_Final, Cancelada, Valor_Dinheiro, Valor_Cheque, 
     Valor_Cartao, Valor_Crediario, Valor_Troco)
     OUTPUT INSERTED.ID 
     values (@ID_Pessoa, @ID_Caixa, @ID_PDV, @ID_Deposito, getdate(), @Itens, @Valor, 
    @Desconto, @Valor_Final, @Cancelada, @Valor_Dinheiro, @Valor_Cheque, @Valor_Cartao, 
     @Valor_Crediario, @Valor_Troco)";
     
//https://pt.stackoverflow.com/q/99816/101
