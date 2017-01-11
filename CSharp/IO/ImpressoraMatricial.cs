var configImpressora = new PrinterSettings();
Console.WriteLine(configImpressora.PrinterName);

var impressora = new System.IO.StreamWriter(@"\\.\PRN");
impressora.Write((char)15); //inicia negrito na maioria das impressoras matriciais
impressora.Write("Teste");
impressora.Flush();
impressora.Close();

//http://pt.stackoverflow.com/a/539/101
