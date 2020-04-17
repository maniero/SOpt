public partial class Form1 : Form {
    Farmer farmer = new Farmer { NumberOfCows = 15 };
    public Form1() => InitializeComponent();
}

public partial class Form1 : Form {
    public Form1() {
        InitializeComponent();
        Farmer farmer = new Farmer { NumberOfCows = 15 };
    }
}

//https://pt.stackoverflow.com/q/180899/101
