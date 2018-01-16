@Override
public boolean equals(Object obj) {
    // Um objeto é sempre igual a ele mesmo
    if (this == obj) return true; 
    // Um objeto nunca deve ser igual a null
    /* Uma pessoa só pode ser igual a outra pessoa.
     * Caso uma pessoa possa ser igual a uma de suas subclasses
     * use !(obj instanceof Person)
     */
    if (obj == null || getClass() != obj.getClass()) return false;
    // Converte a referencia para uma pessoa
    final Person other = (Person)obj;
    //alguma falhar ocorrer na transformação
    if (othe == null) return false;
    // Elas possuem o mesmo salario
    return this.salario == contaDiferente.salario;
}

//https://pt.stackoverflow.com/q/269427/101
