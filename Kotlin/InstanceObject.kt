fun main(args: Array<String>) {
    val minhaTarefa = TarefaDeCasa("Daniel", "Programação", 10, "30 de Setembro")
    minhaTarefa.entregar()
}
class TarefaDeCasa(
    var nomeDoAluno: String,
    var nomeDaMateria: String,
    var nota: Int,
    var dataDeEntrega: String) {

    fun entregar() {
        println("o aluno ${nomeDoAluno} entregou a tarefa do dia ${dataDeEntrega} e recebeu a nota ${nota}")
    }
}

//https://pt.stackoverflow.com/q/244722/101
