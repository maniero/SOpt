class Main {
  public static void main(String[] args) {
     User usuario = new User("joao", "123");
     User usuario2 = new User(null, null);
  }
}

class User {
    private String usuario;
    private String senha;

    public User(String usuario, String senha) {
        setUsuario(usuario);
        setSenha(senha);
    }
    public String getUsuario() { return usuario; }
    public void setUsuario(String usuario) {
        if (usuario == null || usuario.isEmpty()) throw new IllegalArgumentException("usuário esstá inválido");
        this.usuario = usuario;
    }
    public String getSenha() { return senha; }
    public void setSenha(String senha) {
        if (usuario == null || usuario.isEmpty()) throw new IllegalArgumentException("usuário esstá inválido");
        this.senha = senha;
    }
}

//https://pt.stackoverflow.com/q/394053/101
