class Start {
    static void main(String... args) {
        Livro livro = new Livro()
        livro.nome = 'Java: desvendando o segredo para ser mestre em Java'
        livro.descricao = 'Trata de um guia para aperfeiçoar em java'
        livro.valor = 65.65

        Livrofisico fisico = new Livrofisico()
        fisico.nome =" javaScript"
        fisico.valor =39.99
        fisico.mostrarDetalhes()
        println("Taxa de impressão: " + fisico.getTaxaImpressao())

        livro.mostrarDetalhes()

        Livro outroLivro = new Livro()
        outroLivro.descricao =' Como fazer?'
        outroLivro.isbn = ' 8754868596845986946'
        outroLivro.valor = 467.99
        outroLivro.mostrarDetalhes()
        
        livro.valor = 165.65
        livro.mostrarDetalhes()
    }
}

class Livrofisico extends Livro {
    public double getTaxaImpressao() {
        return valor + 5.0
    }
}

class Livro {
    String nome
    String descricao
    double valor
    String isbn

    void mostrarDetalhes() {
        println "mostrando detalhes do livro: "
        println "Nome: " + nome
        println "Descrição: " + descricao
        println "ISBN " + isbn
        println "Valor: "+ valor
        println "-----------------------------"
    }
    public Livro() {
        this.isbn = "0000-0000000-000000-000000-00"
        this.nome = ""
    }
}

//https://pt.stackoverflow.com/q/105586/101
