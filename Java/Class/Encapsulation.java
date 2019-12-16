package Financeiro;

import Academico.Disciplina;

public class Boleto {
    private Aluno aluno;
    private String referencia; //o exercício não fala disto
    private double valor; //seria melhor usar um BigDecimal, mas para exercício ok

    public Boleto(Aluno aluno, String referencia, double valor){
        this.aluno = aluno;
        this.referencia = referencia;
        this.valor = valor;
    }

    public Aluno getAluno() { return aluno; }

    public String getReferencia() { return referencia; }

    public double getValor() { return valor; }

    public double desconto() { //isto faz e retorna o desconto, o nome não é bom
        disciplina = new Disciplina[3]; //isto não parece fazer o menor sentido,nem compila
        if (disciplina) { //onde está a verificação de aprovação?
            valor -=  valor * 0.1;
            return valor;
        }
    }

    public double getValorDesconto() { //qual o intuito disto? O requisito não pede
        return valor; //isto parece estar errado se o método faz sentido existir
    }
}

//https://pt.stackoverflow.com/q/120249/101
