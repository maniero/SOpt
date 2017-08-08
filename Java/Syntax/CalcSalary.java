class Funcionario {
    String nome, dep, banco, RG;
    double salario;
    
    void recebeAumento(double percentual) {
        salario += salario / 100 * percentual;
    }
    public double calculaGanhoAnual() {
         return salario * 13 + salario / 3;
    }
    public static void main(String[] args) {
        Funcionario f1 = new Funcionario();
        f1.nome = "João";
        f1.dep = "Defesa";        
        f1.banco = "Banco do Brasil S.A";
        f1.RG = "798956-5";
        f1.salario = 27000.0;
        f1.recebeAumento(2000);
        System.out.println("Nome: " + f1.nome + "\nDepartamento: " + f1.dep + "\nBanco: " + f1.banco + "\nRG: " + f1.RG + "\nSalário Anual: " + f1.calculaGanhoAnual());
    }
}

//https://pt.stackoverflow.com/q/227561/101
