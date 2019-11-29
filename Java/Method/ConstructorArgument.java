import java.util.Scanner;
 
class Aluno {
    String nome;
    int idade;
    public Aluno(String nome, int idade) {
        this.nome = nome;
        this.idade = idade;
    }
    public Aluno() { }
}
 
class Principal {
    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        Aluno aluno = new Aluno();
        System.out.println("Qual tu nome");
        aluno.nome = entrada.nextLine();
        System.out.println("Qual tu idade");
        aluno.idade = entrada.nextInt();
        System.out.println("Nome: " + aluno.nome + "\nIdade: " + aluno.idade);   
    }
}

//https://pt.stackoverflow.com/q/110799/101
