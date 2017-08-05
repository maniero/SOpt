fun main(args: Array<String>) {
    val texto: String? = null
    println(texto!!) //gerará uma exceção
    //seria o mesmo que println(texto ?: throw NullPointerException())
    //ou ainda println(texto != null ? texto : throw NullPointerException())
}

//https://pt.stackoverflow.com/q/226862/101
