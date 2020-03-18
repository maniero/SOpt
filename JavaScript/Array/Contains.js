function temHabilidade(skills) {
    for (const item of skills) if (item == "JavaScript") return true;
    return false;
}
let skills = ["JavaScript", "ReactJS", "Flutter","React Native"];
var resultado = temHabilidade(skills);
console.log(resultado);

//https://pt.stackoverflow.com/q/440392/101
