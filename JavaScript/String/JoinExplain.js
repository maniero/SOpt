var usuarios = [
    {
        nome: "Diego",
        habilidades: ["Javascript", "ReactJS", "Redux"]
    },
    {
        nome: "Gabriel",
        habilidades: ["VueJS", "Ruby on Rails", "Elixir"]
    }
];
for (let dados of usuarios) console.log("O " + dados.nome + " possui as habilidades: " + dados.habilidades.join(", "));

for (let dados of usuarios) console.log("O " + dados.nome + " possui as habilidades: " + dados.habilidades);

for (let dados of usuarios) console.log(dados.habilidades);

//https://pt.stackoverflow.com/q/439904/101
