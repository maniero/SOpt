public static bool isNotNull(dynamic AnyTypeValue) {
   //tratamentos por tipo
}

public static bool isNotNull(object AnyTypeValue) {
   //tratamentos por tipo
}

public static bool isNotNull<T>(T AnyTypeValue) {
   //não precisa fazer tratamentos por tipo
}

public static bool isNotNull<T>(T AnyTypeValue) where T : class {
   //se tiver que fazer tratamento por tipo, algo está errado
}

//https://pt.stackoverflow.com/q/57333/101
