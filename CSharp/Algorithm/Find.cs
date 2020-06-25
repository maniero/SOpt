public static bool verificar(int cont, int m1, int m2, int[] Cobertura1, int[] Cobertura2) {
    bool encontrou;
    for (int i = 0; i <= cont; i++) encontrou = !(m1 == Cobertura1[i] && m2 == Cobertura2[i] && m1 == Cobertura2[i] && m2 == Cobertura1[i]);
    return encontrou;
}

public static bool verificar(int cont, int m1, int m2, int[] Cobertura1, int[] Cobertura2) {
    for (int i = 0; i <= cont; i++) if (!(m1 == Cobertura1[i] && m2 == Cobertura2[i] && m1 == Cobertura2[i] && m2 == Cobertura1[i])) return true;
    return false;
}

//https://pt.stackoverflow.com/q/251489/101
