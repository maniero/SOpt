public App() :base() {
    this.Dispatcher.UnhandledException += OnDispatcherUnhandledException;
}
public partial class App : Application {
    void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e) {
        // Faz o que quiser aqui.
        e.Handled = true;
    }
}

[System.STAThreadAttribute()]
public static void Main() {
    WpfApplication1.App app = new WpfApplication1.App();
    app.InitializeComponent();
    try {
        app.Run();
    } catch (Exception ex) { //aqui é um bom local para por esta captura geral
        //faz algo aqui
}

//https://pt.stackoverflow.com/q/104714/101
