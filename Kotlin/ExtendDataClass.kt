fun main(args: Array<String>) {
    val pessoa = Person("João", "Silva")
    println(pessoa.fullName)
}

data class Person(val firstName: String, val lastName: String)

val Person.fullName: String
    get() = firstName + " " + lastName
    
//https://pt.stackoverflow.com/q/228429/101
