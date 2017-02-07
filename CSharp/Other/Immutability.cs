var s = "teste";
s = "mudei";

//

struct Point {
    public float X;
    public float Y;
}

//

struct Point {
    private int x;
    private int y;

    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }
}

var p = new Point(2, 5);
// p.x = 7; seria um erro, você nem consegue acessar os membros individualmente.
p = new Point(7, 5);

//

struct Pessoa {
    public string nome; 
    public int idade;
    public Decimal salario;
    public DateTime CadastradaEm;
}

public class Exemplo {
    static void Main() {
        Pessoa p;
        p.nome = "João";
        p.idade = 18;
        Console.WriteLine("{0} tem {1} anos", p.nome, p.idade);

        p.idade = 20;
        Console.WriteLine("{0} tem {1} anos", p.nome, p.idade);
    }
}

//

var i = 0;
i = 5;

//Semanticamente é o mesmo que dizer:

var i = new Int32(0);
i = new Int32(5);

//

int i = 0;
i++;

//é o mesmo que:

int i = default(Int32); //só para mostrar outra forma de interpretar a mesma coisa
i = new Int32(i+1);


//http://pt.stackoverflow.com/q/15510/101
