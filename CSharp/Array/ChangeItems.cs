 var di = new DirectoryInfo(_caminhoEmail);
 FileInfo[] rgFiles = di.GetFiles("*.ost");
 var pasta = new string[regFiles.Length];
 for (var i = 0; i < rgFiles.Length; i++) pasta[i] = rgFiles[i].FullName;
 return pasta;
 
 //https://pt.stackoverflow.com/q/157970/101
