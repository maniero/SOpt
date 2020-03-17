public class Mesa {
    public int Cdmesa { get; set; }
    public int Flsituacao { get; set; }
    public string Status { 
        get {
            if (Flsituacao == 1) return "LIVRE";
            if (Flsituacao ==  2) return "OCUPADO";
            return "RESERVADO";
        }
    }
}

//https://pt.stackoverflow.com/q/162027/101
