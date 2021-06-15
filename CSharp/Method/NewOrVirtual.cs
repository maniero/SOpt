using static System.Console;
					
public class Program {
	public static void Main() {
		Veiculo a = new Carro();
		a.Andar(); //imprime Carro, mesmo que x seja do tipo Veiculo
		Carro b = new Carro();
		b.Andar(); //imprime Carro, claro, isso é fácil deduzir
		Veiculo c = new Veiculo();
		c.Andar(); //imprime Veiculo, é óbvio
		Carro2 d = new Carro2();
		d.Andar(); //óbvio que imprime Carro
		Veiculo e = new Carro2(); //aqui só esconde, não faz polimorfismo, a instância não importa
		e.Andar(); //aqui imprime Veiculo, afinal o tipo da variável é dessa classe
		Carro3 f = new Carro3();
		f.Andar(); //funciona igual, nenhuma confusão
		Veiculo g = new Carro3(); //pode estar esperando polimorfismo que não ocorrerá
		g.Andar(); //funciona igual, mas poderia não ser o que deseja
		Carro4 h = new Carro4();
		h.Andar(); //funciona igual, nenhuma confusão
		Veiculo2 i = new Carro4(); //pode estar esperando polimorfismo que não ocorrerá
		i.Andar(); //funciona igual, mas poderia não ser o que deseja
	}
}
public class Veiculo {
    public virtual void Andar() => WriteLine("Veiculo");
}
public class Carro : Veiculo {
    public override void Andar() => WriteLine("Carro");
}
public class Carro2 : Veiculo {
    public new void Andar() => WriteLine("Carro");
}
public class Carro3 : Veiculo {
    public void Andar() => WriteLine("Carro"); //note o warning
}
public class Veiculo2 {
    public void Andar() => WriteLine("Veiculo");
}
public class Carro4 : Veiculo2 {
    public void Andar() => WriteLine("Carro"); //note o warning
}

//https://pt.stackoverflow.com/q/151243/101
