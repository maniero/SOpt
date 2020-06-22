let dados = [
  {nome: 'Noah', disciplinas: ['Matemática', 'Geografia', 'Inglês']},
  {nome: 'Gael', disciplinas: ['Química', 'Geografia', 'Português']},
  {nome: 'Caleb', disciplinas: ['Matemática', 'Física', 'Artes']}
]

let discip = dados.filter(a => a.disciplinas.includes('Matemática'))

console.log(discip)

//https://pt.stackoverflow.com/q/458535/101
