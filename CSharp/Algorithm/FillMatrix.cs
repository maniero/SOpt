using static System.Console;

public class GotoTest1 {
    static void Main() {
        int x = 200, y = 4;
        var count = 0;
        var array = new string[x, y];
        for (int i = 0; i < x; i++)
            for (int j = 0; j < y; j++)
                array[i, j] = (++count).ToString();
        Write("Enter the number to search for: ");
        var myNumber = ReadLine();
        bool found = Search(array, x, y, myNumber);
        if (found) WriteLine($"The number {myNumber} is found.");
    	else WriteLine($"The number {myNumber} was not found.");
		WriteLine("End of search.");
    }
	private static bool Search(string[,] array, int x, int y, string myNumber) {
		for (int i = 0; i < x; i++) for (int j = 0; j < y; j++) if (array[i, j] == myNumber) return true;
		return false;
	}
}

//https://pt.stackoverflow.com/q/438623/101
