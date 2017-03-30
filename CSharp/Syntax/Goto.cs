class SwitchTest {
    static void Main() {
        Console.WriteLine("Coffee sizes: 1=Small 2=Medium 3=Large");
        Console.Write("Please enter your selection: ");
        string s = Console.ReadLine();
        int n = int.Parse(s);
        int cost = 0;
        switch (n) {
            case 1:
                cost += 25;
                break;
            case 2:
                cost += 25;
                goto case 1;
            case 3:
                cost += 50;
                goto case 1;
            default:
                Console.WriteLine("Invalid selection.");
                break;
        }
        if (cost != 0) Console.WriteLine("Please insert {0} cents.", cost);
        Console.ReadKey();
    }
}

public class GotoTest1 {
    static void Main() {
        int x = 200, y = 4;
        int count = 0;
        string[,] array = new string[x, y];
        for (int i = 0; i < x; i++)
            for (int j = 0; j < y; j++)
                array[i, j] = (++count).ToString();
        Console.Write("Enter the number to search for: ");
        string myNumber = Console.ReadLine();
        for (int i = 0; i < x; i++) {
            for (int j = 0; j < y; j++) {
                if (array[i, j].Equals(myNumber)) goto Found;
            }
        }
        Console.WriteLine("The number {0} was not found.", myNumber);
        goto Finish;
    Found:
        Console.WriteLine("The number {0} is found.", myNumber);
    Finish:
        Console.WriteLine("End of search.");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}

//http://pt.stackoverflow.com/q/20660/101
