public class Produto {
    public int ProdutoId { get; set; }
    public string Nome { get; set; }
    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }
    public virtual ICollection<Foto> Fotos { get; set; } = new List<Foto>;
}

//https://pt.stackoverflow.com/q/108467/101
