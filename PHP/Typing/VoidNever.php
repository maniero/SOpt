function funcao(): void {
    return 1; // dá erro
}

function funcao(): never {
    exit();
    return 'fim'; // dá erro
}

function funcao(): never {
    if (false) exit();
}

//https://pt.stackoverflow.com/a/570163/101
