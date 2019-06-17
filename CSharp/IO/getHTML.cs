using static System.Console;
using System.Net;
using System.IO;
using System.Collections.Generic;
					
public class Program {
	public static void Main() {
		var paginas = BaixarTudo(new List<string>{"http://google.com", "http://yahoo.com"});
		foreach(var item in paginas) {
		    WriteLine(item);
		}
	}
	
	public static List<string> BaixarTudo(List<string> urls) {
		var clients = new List<string>(urls.Count);
	    foreach(var url in urls) {
			var client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
			using(var data = client.OpenRead(url)) {
				using (var reader = new StreamReader(data)) {
			    	clients.Add(reader.ReadToEnd());
				}
			}
	    }
		return clients;
	}
}

//https://pt.stackoverflow.com/q/47315/101
