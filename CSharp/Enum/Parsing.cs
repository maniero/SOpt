using System;
using static System.Console;

public class Program {
    static int Main() {
        WriteLine("Enter client data: ");
        Write("Name: ");
        string clientName = ReadLine();
        Write("Email: ");
        string email = ReadLine();
        Write("Birth date (DD/MM/YYYY): ");
        if (!DateTime.TryParse(ReadLine(), out var birthDate)) return 1;
        WriteLine("Enter order data: ");
        Write("Status: ");
        if (!Enum.TryParse<OrderStatus>(ReadLine(), true, out var status)) return 1;
		return 0;
    }
}
enum OrderStatus {
    Junior = 0,
    MidLevel = 1,
    Senior = 2
}

//https://pt.stackoverflow.com/q/419074/101
