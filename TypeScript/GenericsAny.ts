function funcao<T>(p: T): T {
    return p;
}

function funcao(p: any): any {
    return p;
}

function funcao<T>(p1: T, p2: T): T {
    return p1;
}

function funcao(p1: any, p2 : any): any {
    return p1;
}

function funcao<T extends number>(p1: T): T {
    return p1 + p2;
}

function funcao(p1: any): any {
    return p1 + p2;
}

//https://pt.stackoverflow.com/q/466543/101
