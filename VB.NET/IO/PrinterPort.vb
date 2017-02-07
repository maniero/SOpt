Dim impressora = new System.IO.StreamWriter(@"\\.\COM1");
impressora.Write("Teste");
impressora.Flush();
impressora.Close();

//http://pt.stackoverflow.com/q/15287/101
