fun MutableList<Int>.swap(index1: Int, index2: Int) {
    val tmp = this[index1] // 'this' corresponds to the list
    this[index1] = this[index2]
    this[index2] = tmp
}

val l = mutableListOf(1, 2, 3)
l.swap(0, 2)

MutableList<Int>.swap(l, 0, 2)

//https://pt.stackoverflow.com/q/249543/101
