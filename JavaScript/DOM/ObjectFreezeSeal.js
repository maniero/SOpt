let object1 = {}, object2 = {};
object2["test1"] = "valor teste";
object1["test1"] = "valor teste";
Object.freeze(object1);
Object.seal(object2);
object1["test"] = "valor teste";
object2["test"] = "valor teste";
object1["test1"] = "mudei";
object2["test1"] = "mudei";
console.log(object1["test"]);
console.log(object1["test1"]);
console.log(object2["test"]);
console.log(object2["test1"]);

//https://pt.stackoverflow.com/q/338409/101
