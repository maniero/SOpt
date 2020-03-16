using System;
using EnvDTE;
using EnvDTE80; //não sei se precisa de todos eles
using EnvDTE90;
using EnvDTE90a;
using EnvDTE100;
using System.Diagnostics;

public class CountNonWhiteSpaceCharacters {
    void Count() {
        //coloca onde quiser, pode ser no status, abrir outro tipo de controle, etc.
        MsgBox("Count " + DTE.ActiveDocument.Selection().Text.Length.ToString());
    }
}

//https://pt.stackoverflow.com/q/159109/101
