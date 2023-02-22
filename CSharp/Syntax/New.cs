using System;

public class Test {
    static Guid field;
    static void Main() {}
    static void MethodTakingGuid(Guid guid) {}

    static void ParameterisedCtorAssignToField() => field = new Guid("");

    static void ParameterisedCtorAssignToLocal() {
        Guid local = new Guid("");
        // Forçando o valor a ser usado
        local.ToString();
    }

    static void ParameterisedCtorCallMethod() => MethodTakingGuid(new Guid(""));

    static void ParameterlessCtorAssignToField() => field = new Guid();

    static void ParameterlessCtorAssignToLocal() {
        Guid local = new Guid();
        // Forçando o valor a ser usado
        local.ToString();
    }

    static void ParameterlessCtorCallMethod() => MethodTakingGuid(new Guid());
}

//https://pt.stackoverflow.com/q/577406/101
