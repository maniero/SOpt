using static System.Console;
using System.Collections.Generic;
using System.Linq;
					
public class Program {
	public static void Main() {
		List<Pet> pets =
			new List<Pet>{ new Pet { Name="Barley", Age=8 },
				new Pet { Name="Boots", Age=4 },
				new Pet { Name="Whiskers", Age=1 },
				new Pet { Name="Daisy", Age=4 } };
        //está agrupando por idade e depois po nome.
		//Como existe dois pets com mesma idade eles serão agrupados
		var query =	pets.GroupBy(pet => pet.Age, pet => pet.Name);
		foreach (var petGroup in query) {
			WriteLine(petGroup.Key);
			foreach (var name in petGroup) WriteLine("  {0}", name);
		}
	}
}

class Pet {
	public string Name { get; set; }
	public int Age { get; set; }
}

//https://pt.stackoverflow.com/q/82746/101
