public class PizzaFactory {
    public Pizza CreatePizza(String sabor) {
        if (sabor == "Portuguesa")
            return new Portuguesa();
        if (sabor == "Calabreza")
            return new Calabreza();
        return null;
    }
    ...
}

PizzaFactory fabricaDePizza = new PizzaFactory()
Pizza pizza = fabricaDePizza.createPizza(textBoxPizza);

class static PizzaFactory {
    private Dictionary<string, Pizza> pizzas = new Dictionary<string, Pizza>();
    public static void registerPizza(String nome, Pizza pizza) => pizzas[nome] = pizza;
    public static Pizza createPizza(String nome) => pizzas[nome].createPizza();
}

class Portuguesa : Pizza {
    ...
    static Pizza() => PizzaFactory.registerPizza("Portuguesa", new Portuguesa());
    public override Pizza createPizza() => new Portuguesa();
    ...
}


public abstract class PizzaFactory {
    protected abstract Pizza Make();
    public Pizza GetPizza() => this.Make(); //este é o método de fábrica
}

public class PortuguesaFactory : PizzaFactory {
    protected override Pizza Make() {
        Portuguesa pizza = new Portuguesa();
        pizza.GetHam();
        pizza.GetPea();
        pizza.GetOnion();
        pizza.GetEgg();
        return (Pizza)pizza;
    }
}


public interface IPizzaIngredientFactory {
    public Massa createMassa();
    public Molho createMolho();
    public Queijo createQueijo();
    public Acessorios[] createAcessorios();
    public Carne createCarne();
}

public class PremiumPizzaIngredientFactory : IPizzaIngredientFactory {
    public Massa createMassa() => new MassaFinaCrocante();
    public Molho createMolho() => new MolhoTomateEspecial();
    public Queijo createQueijo() => new QueijoMussarela();

    public Acessorios[] createAcessorios() => new Acessorios { new MiniAzeitona(), new CebolaRoxa() };
    public Carne createCarne() => new CarneRalada();
}

public abstract class Pizza {
    public string Nome;
    protected IMassa Massa;
    protected IMolho Molho;
    protected IAcessorios[] Acessorios;
    protected IQueijo Queijo;
    protected ICarne Carne;
    public abstract void Prepare();
}

public class Calabreza : Pizza {
    IPizzaIngredientFactory ingredientFactory;
    public CheesePizza(IPizzaIngredientFactory ingredientFactory) ingredientFactory = ingredientFactory;
    public override void Prepare() {
        Massa = ingredientFactory.CreateMassa();
        Molho = ingredientFactory.CreateMolho();
        Queijo = ingredientFactory.CreateQueijo();
        Carne = ingredientFactory.CreateCarne();
    }
}

public class PremiumPizza {
    protected override Pizza CreatePizza(string sabor) {
        Pizza pizza;
        IPizzaIngredientFactory ingredientFactory = new PremiumPizzaIngredientFactory();
        switch (sabor) {
        case "Portuguesa":
            pizza = new Portuguesa(ingredientFactory);
            pizza.Nome = "Pizza Premium Portuguesa";
            break;
        case "Calabreza":
            pizza = new Calabreza(ingredientFactory);
            pizza.Nome = "Pizza Premium Calabreza";
            break;
        }
        return pizza;
    }
}

//https://pt.stackoverflow.com/q/157466/101
