using static System.Console;

public class Person {
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
    public string State { get; set; }

    public Person(string fname, string mname, string lname, string cityName, string stateName) {
        FirstName = fname;
        MiddleName = mname;
        LastName = lname;
        City = cityName;
        State = stateName;
    }

    public void Deconstruct(out string fname, out string lname) {
        fname = FirstName;
        lname = LastName;
    }

    public void Deconstruct(out string fname, out string mname, out string lname) {
        fname = FirstName;
        mname = MiddleName;
        lname = LastName;
    }

    public void Deconstruct(out string fname, out string lname, out string city, out string state) {
        fname = FirstName;
        lname = LastName;
        city = City;
        state = State;
    }
}

public class Example {
    public static void Main() {
        var p = new Person("John", "Quincy", "Adams", "Boston", "MA");
        var (fName, lName, city, state) = p; //essa sintaxe é de desconstrução chamando o terceiro método
        WriteLine($"Hello {fName} {lName} of {city}, {state}!");
		var (nome, sobrenome) = p; //aqui chama o primeiro método de desconstrução.
        WriteLine($"{nome} {sobrenome}");
		var (pnome, _, unome) = p; //aqui chama o segundo método de desconstrução.
        WriteLine($"{pnome} {unome}");
    }
}

//https://pt.stackoverflow.com/q/482769/101
