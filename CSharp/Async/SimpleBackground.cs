var backgroundWorker = new BackgroundWorker(); //estará fora do método de escrita

using (var stream = new FileStream(wnd_file, FileMode.OpenOrCreate)) {
    using (var writer = new BinaryWriter(stream)) {
        var remain = wnd_bytes.Length;
        var written = 0;
        while (remain > 0) {
            var size = Math.Min(4096, remain);
            writer.Write(wnd_bytes, written, size);
            written += size;
            remain -= size;
            backgroundWorker.ReportProgress(written * 100 / wnd_bytes.Length);
        }
    }
}

//https://pt.stackoverflow.com/q/48747/101
