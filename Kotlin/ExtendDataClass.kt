fun main(args: Array<String>) {
    val pessoa = Person("João", "Silva")
    pessoa.age = 47
    println(pessoa.fullName)
    println(pessoa.Firula())
    println(pessoa.firula)
    val pessoa2 = pessoa.copy()
    println(pessoa2.age)
    pessoa2.age = 40
    println(pessoa2.age)
    println(pessoa == pessoa2)
    println(pessoa2)
}

data class Person(val firstName: String, val lastName: String) {
    fun Firula(): String = "O nome dele é " + firstName + " " + lastName
	val firula: String
	    get() = "O nome dele é " + firstName + " " + lastName
	var age: Int = 0
	override fun toString() = firstName + " " + lastName
}

val Person.fullName: String
    get() = firstName + " " + lastName
    
//https://pt.stackoverflow.com/q/228429/101
