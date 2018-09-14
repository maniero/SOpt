class Program {
    static void Main(string[] args) {
        try {
            System.Net.WebRequest wc = System.Net.WebRequest.Create("http://www.imdb.com"); //args[0]);

            ((HttpWebRequest)wc).UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/525.19 (KHTML, like Gecko) Chrome/0.2.153.1 Safari/525.19";
            wc.Timeout = 1000;
            wc.Method = "HEAD";
            WebResponse res = wc.GetResponse();
            var streamReader = new System.IO.StreamReader(res.GetResponseStream());

            Console.WriteLine(streamReader.ReadToEnd());
        } catch (Exception ex) {
            Console.WriteLine(ex.Message);
        }
    }
}

//

WebClient foo = new WebClient();
foo.DownloadStringAsync("http://siteDaAplicacao.com.br/Pagina.aspx");

//https://pt.stackoverflow.com/q/39300/101
