public static Control FindFocusedControl(this Control control) {
    var container = control as IContainerControl;
    while (container != null) {
        control = container.ActiveControl;
        container = control as IContainerControl;
    }
    return control;
}

//https://pt.stackoverflow.com/a/45396/101
