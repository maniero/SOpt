public lateinit var prop: String

fun init(param: String) {
   valor = Executa(param)
}

val lazyValue: String by lazy {
    println("computed!")
    "Hello"
}

//https://pt.stackoverflow.com/q/227407/101
