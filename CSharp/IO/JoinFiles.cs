using System;
using System.IO;
using Util.IO;

public class MergeFiles {
    public static void Main(string[] args) {
        int bufferSize;
        FileUtil.MergeTextFiles(args[0], args[1], args[2], (int.TryParse(args[3], out bufferSize) ? bufferSize : 0));
    }
}

namespace Util.IO {
    public static class FileUtil {
        public static void MergeTextFiles(string targetFileName, string sourcePath, string searchPattern = "*.*", int bufferSize = 0) {
        if (string.IsNullOrEmpty(sourcePath)) {
            sourcePath = Directory.GetCurrentDirectory();
        }
            if (targetFileName.IndexOfAny(System.IO.Path.GetInvalidPathChars()) != -1) {
                throw new ArgumentException("Diretório fonte especificado contém caracteres inválidos", "sourcePath");
            }
            if (string.IsNullOrEmpty(targetFileName)) {
                throw new ArgumentException("Nome do arquivo destino precisa ser especificado", "targetFileName");
            }
            if (string.IsNullOrEmpty(targetFileName)) {
                throw new ArgumentException("Nome do arquivo destino precisa ser especificado", "targetFileName");
            }
            if (targetFileName.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) != -1) {
                throw new ArgumentException("Nome do arquivo destino contém caracteres inválidos", "targetFileName");
            }
            var targetFullFileName = Path.Combine(sourcePath, targetFileName);
            if (bufferSize == 0) {
                File.Delete(targetFullFileName);
                foreach (var file in Directory.GetFiles(sourcePath, searchPattern)) {
                    if (file != targetFullFileName) {
                        File.AppendAllText(targetFullFileName, File.ReadAllText(file));
                    }
                }
            } else {
                using (var targetFile = File.Create(targetFullFileName, bufferSize)) {
                    foreach (var file in Directory.GetFiles(sourcePath, searchPattern)) {
                        if (file != targetFullFileName) {
                            using (var sourceFile = File.OpenRead(file))    {
                                var buffer = new byte[bufferSize];
                                int bytesRead;
                                while ((bytesRead = sourceFile.Read(buffer, 0, buffer.Length)) > 0) {
                                    targetFile.Write(buffer, 0, bytesRead);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

//http://pt.stackoverflow.com/q/16704/101
