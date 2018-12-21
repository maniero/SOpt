public void update(Pessoa pessoa) throws SQLException { //note o throws aqui
    PreparedStatement preparedStatement = conexao.prepareStatement(sqlUpdate);
    preparedStatement.setString(1, pessoa.getNome());
    preparedStatement.setString(2, pessoa.getCpf());
    preparedStatement.setInt(3, pessoa.getIdPessoa());
    preparedStatement.execute();
    preparedStatement.close();
    conexao.close();
}

//https://pt.stackoverflow.com/q/44501/101
