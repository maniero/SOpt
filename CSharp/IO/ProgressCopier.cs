public delegate void ProgressChangeDelegate(double percentage, ref bool cancel);
public delegate void CompleteDelegate();

class CustomFileCopier {
    public CustomFileCopier(string source, string dest) {
        this.SourceFilePath = source;
        this.DestFilePath = dest;
        OnProgressChanged += delegate { }; //só para facilitar o exemplo aqui
        OnComplete +=  delegate { }; //só para facilitar o exemplo aqui
    }

    public void Copy() {
        byte[] buffer = new byte[1024 * 1024]; // 1MB buffer
        bool cancelFlag = false;
        using (FileStream source = new FileStream(SourceFilePath, FileMode.Open, FileAccess.Read)) {
            long fileLength = source.Length;
            using (FileStream dest = new FileStream(DestFilePath, FileMode.CreateNew, FileAccess.Write)) {
                long totalBytes = 0;
                int currentBlockSize = 0;
                while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0) {
                    totalBytes += currentBlockSize;
                    double percentage = (double)totalBytes * 100.0 / fileLength;
                    dest.Write(buffer, 0, currentBlockSize);
                    cancelFlag = false;
                    OnProgressChanged(percentage, ref cancelFlag);
                    if (cancelFlag == true) {break; } // Delete dest file here
                }
            }
        }
        OnComplete();
    }

    public string SourceFilePath { get; set; }
    public string DestFilePath { get; set; }

    public event ProgressChangeDelegate OnProgressChanged;
    public event CompleteDelegate OnComplete;
}

//http://pt.stackoverflow.com/q/22776/101
