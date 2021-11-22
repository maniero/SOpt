using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Program {
	public static void Main() {
		var x = new Test();
		x.Foo = 10;
	}
}
public class Test: INotifyPropertyChanged {
    private int foo;
    public int Foo { get => foo; set => this.Set(ref foo, value, PropertyChanged); }
	public event PropertyChangedEventHandler PropertyChanged;
	protected void OnPropertyChanged(string name) {
		PropertyChangedEventHandler handler = PropertyChanged;
		if (handler != null) handler(this, new PropertyChangedEventArgs(name));
	}
}

public static class Extensions {
    public static void Set<T>(
        this INotifyPropertyChanged source, ref T property, T value, PropertyChangedEventHandler handler, [CallerMemberName]string propertyName = "") {
        property = value;
        handler?.Invoke(source, new PropertyChangedEventArgs(propertyName));
    }
}

//https://pt.stackoverflow.com/q/347780/101
