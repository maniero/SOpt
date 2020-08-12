pessoas = [];
pessoas.push({"nome": "Pedro"})
pessoas.push({"nome": "João"})
pessoas.push({"nome": "Maria"})
pessoas.push({"nome": "José"})

function encontrar() {
    for (let pessoa of pessoas) {
        if (pessoa.nome === 'Pedro') {
            console.log('Já existe');
            return;
        }
    }
    console.log('Não existe');
}
encontrar()

//https://pt.stackoverflow.com/q/339983/101
