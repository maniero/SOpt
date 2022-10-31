using static System.Console;

while (true) {
    if (!int.TryParse(ReadLine(), out var x)) return;
    if (!int.TryParse(ReadLine(), out var y)) return;
    if (x == 0 || y == 0) break;
    if (x > 0 && y > 0) WriteLine("primeiro");
    else if (x < 0 && y > 0) WriteLine("segundo");
    else if (x < 0 && y < 0) WriteLine("terceiro");
    else WriteLine("quarto");
}                    

//https://pt.stackoverflow.com/q/568875/101
