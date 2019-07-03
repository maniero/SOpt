private async Task AccountsReceivable() {
    using  (SqlConnection con = clsdb.AbreBanco())
    using (var cmd1 = new SqlCommand("procedimento", con)) {
        cmd1.CommandType = CommandType.StoredProcedure;
        cmd1.CommandTimeout = 20000;
        await cmd1.ExecuteNonQueryAsync().ConfigureAwait(false);
    }
}

//https://pt.stackoverflow.com/q/395016/101
