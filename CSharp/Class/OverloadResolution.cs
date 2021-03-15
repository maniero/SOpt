using static System.Console;

public class Program {
	public static void Main() {
		var x = new MyList<int>();
		var y = x;
		WriteLine(x.Equals(y));
	}
}

class MyList<T> {
    public override bool Equals(object obj) {
		WriteLine("instância");
        if (obj is MyList<T>) {
            return Equals((MyList<T>)obj, this);
        }
        return false;
    }

    public static bool Equals(MyList<T> listA, MyList<T> listB) {
		WriteLine("estático");
        return true;
    }
}
