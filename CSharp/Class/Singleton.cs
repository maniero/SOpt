public class Program {
	public static void Main() {
		var singleton = MyClass.Instance;
	}
}

public class MyClass {
   private static MyClass instance;
   private MyClass() {}
   public static MyClass Instance {
      get {
         if (instance == null) instance = new MyClass();
         return instance;
      }
   }
}

//https://pt.stackoverflow.com/q/52250/101
