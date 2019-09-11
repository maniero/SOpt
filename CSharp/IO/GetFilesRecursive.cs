using static System.Console;
using System.IO;
using System.Collections.Generic;
					
public class Program {
	public static void Main() {
	    foreach (var file in FileUtil.GetFiles("c:\\", "aria2c.exe")) WriteLine(file);
	}
}

public static class FileUtil {
    public static IEnumerable<string> GetFiles(string root, string searchPattern) {
        var pending = new Stack<string>();
        pending.Push(root);
        while (pending.Count != 0) {
            var path = pending.Pop();
            string[] next = null;
            try {
                next = Directory.GetFiles(path, searchPattern);                    
            }
            catch { } //aqui você pode colocar log, aviso ou fazer algo útil se tiver problemas
            if (next != null && next.Length != 0) foreach (var file in next) yield return file;
            try {
                next = Directory.GetDirectories(path);
                foreach (var subdir in next) pending.Push(subdir);
            }
            catch { } //aqui você pode colocar log, aviso ou fazer algo útil se tiver problemas
        }
    }
}

//https://pt.stackoverflow.com/q/75167/101
