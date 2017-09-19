using System;
using static System.Console;
using System.IO;

public class CreateFileOrFolder {
    public static void Main() {
        var activeDir = @"B:\Quality\QAS\FOTOS DO FERRAMENTAL";
        string newPath = Path.Combine(activeDir, DateTime.Now.ToString("yyyyMMdd"));
        Directory.CreateDirectory(newPath);
        newPath = Path.Combine(newPath, Path.GetRandomFileName());
        if (!File.Exists(newPath)) { //isto pode dar condição de corrida, mas vou deixar
            using (FileStream fs = File.Create(newPath)) {
                for (byte i = 0; i < 100; i++) {
                    fs.WriteByte(i); //isto é lento pra bedéu
                }
            }
        }
        byte[] readBuffer = File.ReadAllBytes(newPath);
        foreach (byte b in readBuffer) {
            WriteLine(b);
		}
        WriteLine("Diretorio criado com sucesso, Pressione qualquer tecla para iniciar o programa de captura.");
    }
}

//https://pt.stackoverflow.com/q/238679/101
