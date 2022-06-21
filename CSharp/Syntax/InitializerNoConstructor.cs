man = new {Cash = 50, Name = "Joe"};

man = new Guy();
man.Cash = 50;
man.Name = "Joe";

public class Guy {
    public IServicoDeTransforcao Servico { private get; init; }
    public int Cash { get; set; }
    public string Name { get;  set; }

}

//https://pt.stackoverflow.com/q/556202/101
