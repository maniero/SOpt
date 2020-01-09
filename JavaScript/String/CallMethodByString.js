function sayHello() {
    console.log('Hello');
}

window["sayHello"]();
this["sayHello"]();
self["sayHello"]();
//top["sayHello"](); //tem problemas de permissão
globalThis["sayHello"]();

//https://pt.stackoverflow.com/q/429796/101
