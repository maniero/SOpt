public class Classe {
    Temp temp = new Temp();
    public string Texto { get => temp.Str; set => temp.Str = value; }
    public int Valor { get => temp.I; set => temp.I = value; }

    private class Temp {
        public string Str { get; set; }
        public int I { get; set; }
    }
}

//https://pt.stackoverflow.com/q/290621/101
