// This sample code demonstrates "Initializers for auto-properties" feature of Roslyn 
//
// To try out other Roslyn features go to
// https://roslyn.codeplex.com/wikipage?title=Language%20Feature%20Status&referringTitle=Home
//
// C# samples PDF
// https://www.codeplex.com/Download?ProjectName=roslyn&DownloadId=824694
//
// VB.NET samples PDF
// https://www.codeplex.com/Download?ProjectName=roslyn&DownloadId=826498

using System;

public class Program
{
	
	public class Customer 
	{ 
		// Initializers for auto-properties 
 		public string First { get; set; } = "Jane"; 
 		public string Last { get; set; } = "Doe"; 
	} 
		
	
	public static void Main()
	{
		var customer = new Customer();
		
		Console.WriteLine("First: " + customer.First);
		Console.WriteLine("Last: " + customer.Last);
			
	}
}

//http://pt.stackoverflow.com/q/16704/101
