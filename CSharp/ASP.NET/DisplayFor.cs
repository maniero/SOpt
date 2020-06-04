@Html.DisplayNameFor(model => model.Title) //mostra Title
@Html.DisplayFor(model => model.Title) //mostra o conteúdo de Title

public class Livro {
    [Display(Name = "Tíulo do livro")]
    public string Title{ get; }
}

//https://pt.stackoverflow.com/q/227462/101
