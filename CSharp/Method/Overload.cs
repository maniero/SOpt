public string GetControlXXX(ToolStripMenuItem ctrl) { //talvez poderia até ter outro nome
    ...
    GetMenuItems(ctrl , items);
    ...
    return ...;
 }
 public string GetControlXXX(Control ctrl) {
    ...
    //faz alguma coisa com ctrl, mas não precisa ver se é um ToolStripMenuItem
    ...
    return ...;
 }
 
 //https://pt.stackoverflow.com/q/135702/101
