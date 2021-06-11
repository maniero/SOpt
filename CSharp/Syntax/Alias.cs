using WF = System.Windows.Forms; //só fez o alias do namespace

var botao = new WF.Button();

using Dict = System.Collections.Generic.Dictionary<string, List<string>>;

var dict = new Dict { "palavra", new List<string> { "definição1", "definicão2" },  "palavra2", new List<string> { "definição1", "definicão2" } };

//https://pt.stackoverflow.com/q/134939/101
