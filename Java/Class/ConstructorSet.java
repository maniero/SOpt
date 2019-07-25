import java.util.Scanner;

class Main {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        Paciente p01 = new Paciente();
        System.out.println("Digite o nome do Paciente: ");
        String nomeDoPaciente = input.nextLine();
        p01.setNome(nomeDoPaciente);
    }
}

class Paciente{
	private double cod;
	private String nome;
    public String getNome() { return this.nome; }
    public void setNome(String NomedoPaciente) { this.nome = NomedoPaciente; }
}

//https://pt.stackoverflow.com/q/399061/101
