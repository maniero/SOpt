catch (MyException ex) {
    ex.Handle();
}

try {
    //Algum trecho de código
} catch (MyException myException) {
    ex.Handle();
} catch (Exception ex) {
    ex.Handle();
}

public static void Handle(this MyException exp) {
    //Aqui faço alguma coisa
}
public static void Handle(this MyException exp, string message) {
    //Aqui faço alguma coisa
}
public static void HandleSpecific(this MyException exp) {
    //Aqui faço alguma coisa
}

//https://pt.stackoverflow.com/q/441860/101
