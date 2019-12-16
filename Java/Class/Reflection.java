for (Field field : Pessoa.class.getDeclaredFields()) {
    if (Modifier.isPrivate(field.getModifiers())) {
        //faz alguma coisa aqui com field
    }
}

//https://pt.stackoverflow.com/q/120771/101
