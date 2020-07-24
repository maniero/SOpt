var obj = { cidade : undefined, estado : "", cep : "123" };
if (obj.cidade === undefined) console.log("cidade não tem valor");
if (obj.empresa === undefined) console.log("estado não tem valor");
if (obj.representante === undefined) console.log("cep não tem valor");

var obj = { cidade : "abc", estado : "", cep : "123" };
if (obj.cidade === undefined || obj.cidade === "" ||
    obj.empresa === undefined || obj.empresa === "" ||
    obj.representante === undefined || obj.representante === "") console.log("algum campo não tem valor");

var obj = { cidade : undefined, estado : "", cep : "123" };
if (temCampoInvalido(obj)) console.log("algum campo não tem valor");
var obj = { cidade : "cidade", estado : "", cep : "123" };
if (temCampoInvalido(obj)) console.log("algum campo não tem valor");

function temCampoInvalido(obj) {
    for (var value of Object.values(obj)) if (value === undefined) return true;
    return false;
}

//https://pt.stackoverflow.com/q/313639/101
