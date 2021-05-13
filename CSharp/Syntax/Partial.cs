//Arquivo1
partial class form1 {
    ...
    private void InitializeComponent() {
        ...
        InitializeComponentAux();
    }
    ...
}
//Arquivo2
partial class form1 : Form {
     ...
     partial void InitializeComponentAux() {
           ...
     }
}

//Arquivo1
partial class form1 {
    ...
    private void InitializeComponent();
    ...
}
//Arquivo2
partial class form1 : Form {
     ...
     partial void InitializeComponent() {
           ...
     }
}

//https://pt.stackoverflow.com/q/44333/101
