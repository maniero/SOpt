using ImageControl = System.Windows.Controls.Image;
using Image = System.Drawing.Image;
using ListString = System.Collections.Generic.List<string>;
ListString lista; // a variável lista será do tipo System.Collections.Generic.List<string>;
ImageControl img1; // img1 será do tipo System.Windows.Controls.Image
Image img2; // img1 será do tipo System.Drawing.Image sem nenhum conflito com o Image acima

using static System.Console;
WriteLine("Exemplo");

//é o mesmo que escrever:

System.Console.WriteLine("Exemplo");

//http://pt.stackoverflow.com/q/16563/101
