public class Program {
	public static void Main() {
		var myClassObject = new MyClass() { Prop1 = "Teste", Prop2 = 10, FieldArray = new Field<dynamic>[2] { new Field<dynamic>("f1", "v1"), new Field<dynamic>("f1", 1) } };
	}
}

public class Field<TValue> {
    public string Name { get; set; }
    public TValue Value { get; set; }

    public Field() {}

    public Field(string name, TValue value) {
        this.Name = name;
        this.Value = value;
    }
}

public class MyClass {
    public string Prop1 { get; set; }
    public int Prop2 { get; set; }
    public Field<dynamic>[] FieldArray { get; set; }
}

//https://pt.stackoverflow.com/q/241121/101
