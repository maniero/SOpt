var cpf = "11111111111"; //se não for só um teste não precisa da variável
DbConnection cnx = ADO_Utils.GetConnection();
DbCommand cmd = ADO_Utils.GetComando(cnx);
cmd.CommandType = CommandType.Text;
for (var i = 1; i < Convert.ToInt32(txbQtde.Text); i++) { // <==== note que não tem o ;
    cmd.CommandText = @"insert into tblAcordoParcel (txtCPF, intParcela, dblValorParcel, 
dtVencimento, blnBaixada) Values (@cpf, @i, @parcel, @dt, 0)";
    cmd.Parameters.AddWithValue("@cpf", cpf);
    cmd.Parameters.AddWithValue("@i", i);
    cmd.Parameters.AddWithValue("@parcel", txbParcel.Text);
    cmd.Parameters.AddWithValue("@dt", txbDt.Text);
    cmd.ExecuteNonQuery();
    
//https://pt.stackoverflow.com/q/124601/101
