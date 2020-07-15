class Base
    x : int

class Derivada : Base
    y : int

b := Base()
d := Derivada() { x = 1, y = 2 }
b = d //funciona porque d é do tipo de b, nem toda linguagem deixa implicitamente
print b.x //sem problemas, dá 1
//print b.y //daria erro porque em b não tem y, então não temos problema aqui
d = b
print d.x //beleza, dá 1
print d.y //agora pode, d tem um y, mas imprime 2?

//https://pt.stackoverflow.com/q/286437/101
