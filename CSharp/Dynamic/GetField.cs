using System;
using static System.Console;
using System.Reflection;

public class Program {
	public static void Main() {
		var teste = new Teste();
		teste.ListProperties();
		WriteLine(teste.GetPropValue<int>("y"));
		var teste2 = new Teste2();
		teste2.ListFields();
	}
}

public class Teste {
    public int x { get; set; } = 10;
    public int y { get; set; } = 10;
}

public class Teste2 {
    public int x = 10;
    public int y = 10;
}

public static class ObjectExt {
    public static void ListProperties(this object obj) {
		foreach(var prop in obj.GetType().GetProperties()) {
			WriteLine($"{prop.Name} = {prop.GetValue(obj, null)}");
		}
	}
    public static void ListFields(this object obj) {
		foreach(var field in obj.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)) {
			WriteLine($"{field.Name} = {field.GetValue(obj)}");
		}
	}
    public static T GetPropValue<T>(this object value, string propertyName) {
        if (value == null) { throw new ArgumentNullException("value"); }
        if (String.IsNullOrEmpty(propertyName)) { throw new ArgumentException("propertyName"); }
        PropertyInfo info = value.GetType().GetProperty(propertyName);
        return (T)info.GetValue(value, null);
    }
	public static FieldInfo GetFieldInfo(this Type objType, string fieldName, BindingFlags flags, bool isFirstTypeChecked = true) {
		FieldInfo fieldInfo = objType.GetField(fieldName, flags);
		if (fieldInfo == null && objType.BaseType != null) fieldInfo = objType.BaseType.GetFieldInfo(fieldName, flags, false);
	
		if (fieldInfo == null && isFirstTypeChecked) throw new MissingFieldException(String.Format("Field {0}.{1} could not be found with the following BindingFlags: {2}", objType.ReflectedType.FullName, fieldName, flags.ToString()));
		return fieldInfo;
	}
}

//https://pt.stackoverflow.com/q/105236/101
