abstract class Pessoa {
    id?: number;
    nome?: string;
}

class PessoaFisica extends Pessoa {
    public cpf? : string;
    public rg? : string;
    public sexo? : string;
    public profissao? : string;
    public data_nascimento? : Date

}

class PessoaJuridica extends Pessoa {
    public razaoSocial? : string;
    public cnpj? : string;
    public ie? : string;
    public im? : string;
}

class Cliente<T> {
    id? : number;
    pessoable? : Pessoa;
    pessoa? : T;
    pessoa2? : PessoaFisica | PessoaJuridica
}

let c : Cliente<PessoaFisica> = new Cliente();
c.pessoable = new PessoaFisica();
let x = c.pessoable as PessoaFisica;
x.cpf = "123";
c.pessoa = new PessoaFisica();
c.pessoa.cpf = "123";
c.pessoa2 = new PessoaFisica();
c.pessoa.cpf = "123";

//https://pt.stackoverflow.com/q/451967/101
