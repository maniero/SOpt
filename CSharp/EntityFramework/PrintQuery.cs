// @nuget: EntityFramework
using System;
using System.Linq;
using System.Data.Entity;

public class Program {
	public static void Main() {
		using (var ctx = new FazendaContext()) {
			var boi = new Boi() { ID = 1 };
			ctx.Gado.Add(boi);
			ctx.SaveChanges(); 
			IQueryable query = from x in ctx.Gado
		             where x.ID == 1
		             select x;
			Console.Write(query);
		}
	}
}

public class FazendaContext: DbContext {
	public FazendaContext() : base(FiddleHelper.GetConnectionStringSqlServer()) {}
	public DbSet<Boi> Gado { get; set; }
}

public class Boi {
    public int ID { get; set; }
}

//https://pt.stackoverflow.com/q/455662/101
