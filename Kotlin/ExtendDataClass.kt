fun main(args: Array<String>) {
    val pessoa = Person("João", "Silva")
    println(pessoa.fullName)
    println(pessoa.Firula())
}

data class Person(val firstName: String, val lastName: String) {
    fun Firula(): String = "O nome dele é " + firstName + " " + lastName
}

val Person.fullName: String
    get() = firstName + " " + lastName
    
//https://pt.stackoverflow.com/q/228429/101
