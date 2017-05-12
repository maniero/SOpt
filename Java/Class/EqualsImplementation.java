@Override
public boolean equals(Object obj) {
    // Um objeto é sempre igual a ele mesmo
    if (this == obj) {
        return true; 
    }
    // Um objeto nunca deve ser igual a null
    if (obj == null) {
        return false;
    }
    /* Uma pessoa só pode ser igual a outra pessoa.
     * Caso uma pessoa possa ser igual a uma de suas subclasses
     * use !(obj instanceof Pessoa)
     */
    if (getClass() != obj.getClass()) {
        return false;
    }
    // Converte a referencia para uma pessoa
    final Pessoa other = (Pessoa) obj;
    // Duas pessoas só podem ser comparadas se possuem CPF
    if (this.cpf == null || other.cpf == null) {
        return false;
    }        
    // Duas pessoas são iguais se possuem o mesmo CPF
    return this.cpf.equals(other.cpf);
}

//https://pt.stackoverflow.com/q/34562/101
