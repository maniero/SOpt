T Metodo<T>(T obj) where T : TipoPai {
    return obj.ChamaAlgo(); //Qual "ChamaAlgo()" será executado?
}

class exemplo<out T> //covariante

class exemplo<in T>  //contravariante

//https://pt.stackoverflow.com/q/10032/101
