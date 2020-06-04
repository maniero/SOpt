import java.io.File
import java.io.InputStream

fun main(args: Array<String>) {
    val inputStream: InputStream = File("kotlination.txt").inputStream()

    val inputString = inputStream.bufferedReader().use { it.readText() }
    println(inputString)
}

import java.io.File
import java.io.InputStream

fun main(args: Array<String>) {
    val inputStream: InputStream = File("kotlination.txt").inputStream()
    val lineList = mutableListOf<String>()

    inputStream.bufferedReader().useLines { lines -> lines.forEach { lineList.add(it)} }
    lineList.forEach{println(">  " + it)}
}

import java.io.File
import java.io.BufferedReader

fun main(args: Array<String>) {
    val bufferedReader: BufferedReader = File("kotlination.txt").bufferedReader()

    val inputString = bufferedReader.use { it.readText() }
    println(inputString)
}

import java.io.File
import java.io.BufferedReader

fun main(args: Array<String>) {
    val bufferedReader = File("kotlination.txt").bufferedReader()
    val lineList = mutableListOf<String>()

    bufferedReader.useLines { lines -> lines.forEach { lineList.add(it) } }
    lineList.forEach { println(">  " + it) }
}

//https://pt.stackoverflow.com/q/227393/101
