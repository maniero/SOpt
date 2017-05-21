using System.Collections.Generic;

public class Program {
	public static void Main() {
		var list = new List<object> {
		    "abc",      // string
		    1,          // int
		    true        // bool
		};
		var TempData = new Dictionary<string, object>();
		TempData["ID"] = list;
		var data = TempData["ID"];
		var test1 = ((List<object>)data)[0];
	}
}

//https://pt.stackoverflow.com/q/206269/101
