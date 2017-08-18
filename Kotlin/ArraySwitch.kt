import java.util.*
 
fun main(args: Array<String>) {
    val month = 8
    val monthString = if (month < 1 || month > 12) "Invalid month" else arrayOf("January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December")[month - 1]
    println(monthString)
}

//https://pt.stackoverflow.com/q/230288/101
