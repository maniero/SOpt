public class insertLivros {
    public static void insertLivro(Livros livro) {
        try {
            Connection connection = Conexao.getConexao();
            PreparedStatement pstmt = connection.prepareStatement("insert into livros(nomelivro, nomegenero, nomeautor) VALUES(?, ?, ?)");
            pstmt.setString(1, livro.getNomeLivro());
            pstmt.setString(2, livro.getNomeGenero());
            pstmt.setString(3, livro.getNomeAutor());
            pstmt.executeUpdate();
        } finally {
            connection.close();
        }
    }
}

public class Conexao {
    public static Connection getConexao(){
        Class.forName("com.mysql.jdbc.Driver"); //não sei se isto é necessário
        return DriverManager.getConnection("root", "guimazx33", "jdbc:mysql://localhost/aula");
    }
}

//https://pt.stackoverflow.com/q/256557/101
