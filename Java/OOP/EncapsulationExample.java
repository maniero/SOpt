public abstract class Conta {
    private string documento; //todos aqui estão encapsulados
    private string titular;
    private BigDecimal saldo;
    private BigDecimal limite;
    private Date ultimaTroca;
    public Conta(string documento, string nome, BigDecimal saldo, BigDecimal limite) {
        if (!validaDocumento(documento)) throw DocumentoInvalaidoException();
        this.documento = documento
        this.nome = nome;
        this.saldo = saldo;
        this.limite = limite;
        ultimaTroca = new Date();
    }
    private bool trocaEstaDisponivel() { //encapsula a lógica de verificação, não interessa externamente
        return new Date().getTime() - ultimaTroca.getTime() < 1000 * 60 * 60 * 24 * 30 * 6;
    }
    private bool PodeSacar(BigDecimal saque) {
        return saldo + limite - saque >= 0;
    }
    protected abstract bool ValidaDocumento(string documento);  //encapsulado só entre a hierarquia, haverá polimorfismo
    public abstract bool CadastroValido(); //é polimorfico, só o descendente terá implementação
    public bool TrocaNome(string nome) { //público é o que pode fazer publicamente, o resto é detalhe interno
        if (trocaEstaDisponivel()) {
            this.nome = nome;
            return true;
        }
        return false;
    }
    public void Deposita(BigDecimal deposito) {
        saldo += deposito;
    }
    public bool Saca(BigDecimal saque) {
        if (PodeSacar(saque)) {
            saldo -= saque;
            return true;
        }
        return false;
    }
}

public class ContaJuridica : Conta {
    public ContaJuridica(string documento, string nome, BigDecimal saldo, BigDecimal limite) {
        Conta(documento, nome, saldo, limite);
    }
    @Override protected ValidaDocumento(string documento) {
        return true; //só para facilitar, aqui verificaria o CNPJ
    }
    @Override public CadastroValido() {
        return true; //aqui iria buscar na receita se o cadastro está ativou ou fazer outra coisa
    }
}
    
//o mesmo poderia ser feito para pessoa fisica

public class main() {
    public static void main (String[] args) {
        ContaJuridica conta = new ContaJuridica("01456789000159", "João da Silva", 100, 50);
        conta.Deposita(20);
        if (!conta.trocaNome("José da Silva)) System.out.println("Não pode ficar trocando nome toda hora");
        if (!conta.Saca(200)) System.out.println("Tá achando que o saco não tem fundo?");
        testarConta(conta.CadastroValido());
    }
    public void TestaConta(Conta conta) { //note que recebe uma Conta e não ContaJuridica, então o uso será polimorfico
        if (!conta.CadastroValido()) System.out.println("Sua conta precisa ser regularizada"); //chama método de ContaJuridica
    }
}

//https://pt.stackoverflow.com/q/214767/101
