public bool ValidaCampos(string Nome) {
    cD.CommandText= "select count(*) FROM USER where racf = @user";
    cD.Parameters.AddWithValue("@user", Nome);
    return cD.ExecutaScalar(str) > 0;
}

//https://pt.stackoverflow.com/q/339981/101
