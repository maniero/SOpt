public class WebBrowserAsync {
    protected WebBrowser WebBrowser;
    private ManualResetEventmre = new ManualResetEvent(false);

    public void SetBrowser(WebBrowser browser) {
        this.WebBrowser = browser;
        browser.LoadCompleted += new LoadCompletedEventHandler(WebBrowser_LoadCompleted);
    }

    public async void NavigateAsync(string url, Action action) {
        Navigate(url);
        await Task.Factory.StartNew((Action)(() => { //isto ainda me parece certo
            mre.WaitOne();
            mre.Reset();
        }));
        action();
    }

    public void Navigate(string url) {
        WebBrowser.Navigate(new Uri(url));
    }

    void WebBrowser_LoadCompleted(object sender, NavigationEventArgs e) {
        mre.Set();
    }
}

//https://pt.stackoverflow.com/q/48925/101
