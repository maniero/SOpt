class Main {
    public static void main(String[] args) {
        Pessoa pessoa = new Pessoa(10);
        pessoa.souVelho();
        Pessoa pessoa2 = new Pessoa(15);
        pessoa2.souVelho();
        Pessoa pessoa3 = new Pessoa(20);
        pessoa3.souVelho();
        Pessoa pessoa4 = new Pessoa(-1);
        pessoa4.souVelho();
    }
}

class Pessoa {
    private int idade;  
    public Pessoa(int idadeInicial) {
        if (idadeInicial < 0) {
            idade = 0;
            System.out.println("Idade invalida, idade determinada para 0.");
        } else {
            idade = idadeInicial;
        }
    }
    public void souVelho() {
        System.out.println(idade);
        if (idade >= 0 && idade <= 12) System.out.println("Você é novo.");
        else if (idade >= 13 && idade <= 17) System.out.println("Você é adolescente.");
        else if (idade >= 18) System.out.println("Você é velho.");
    }
    public void fazAniversario() {
        idade++;
    }
}

//https://pt.stackoverflow.com/q/231387/101
