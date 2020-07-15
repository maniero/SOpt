function experiencia(anos) {
    if (anos <= 1) return 'Iniciante';
    else if (anos <= 3) return 'Intermediário';
    else if (anos <= 6) return 'Avançado';
    else return 'Jedi Master';
}

console.log(experiencia(1));

//https://pt.stackoverflow.com/q/462231/101
