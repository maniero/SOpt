public boolean depositoConta(double quantia) {
    System.out.println("Metodo de Doposito()"); //isto não deveria estar aqui
    try {
        Connection con = this.getConexao(); //isto não deveria ser assim
        PreparedStatement stmt = con.prepareStatement("UPDATE conta SET saldo = saldo + ? WHERE idconta = ?");
        stmt.setDouble(1, quantia);
        stmt.setInt(2, getId()); //tenho medo do que seja isto, deveria ser um parâmetro
        return stmt.executeUpdate() != 0;
    } catch (Exception e) { //isto pega qualquer erro e não apenas o que deveria
        System.out.println("Erro no método Deposito: " + e.getMessage());
        e.printStackTrace();
        return false;
    } finally {
        con.close();
    }
}

public boolean deposito(int idConta, double quantia) { //id aqui bem melhor
    try {
        Conta conta = new Conta(idConta); //deveria poder fazer isto
        boolean executado = conta.depositoConta(quantia);
        System.out.println(executado ? "Deposito efetuado com sucesso." : "Erro ao Efeuar o Deposito" );
        return executado;
    } catch (Exception e) {
        System.out.println("Erro no serviço deposito: " + e.getMessage());
        return false;
    }   
}

//https://pt.stackoverflow.com/q/256552/101
