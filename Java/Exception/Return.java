try {
    System.out.println("Parte 1");
} finally {
    System.out.println("Parte 2");
}
return false;

//Já

try {
    System.out.println("Parte 1");
    return false;
} finally {
    System.out.println("Parte 2");
    return true;
}

//Será transformado em:

try {
    System.out.println("Parte 1");
} finally {
    System.out.println("Parte 2");
}
return true;

//https://pt.stackoverflow.com/q/42313/101
