public class Academico {
    public int Id { get; set; }
    public Professor Professor { get; set; }
    public Usuario Usuario { get; set; }
}

public class Academico {
    public int Id { get; set; }
    public Professor Professor { get; set; }
    public int UsuarioId { get; set; }
}

//https://pt.stackoverflow.com/q/245182/101
