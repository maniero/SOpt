let str2 = function(strs, str) {    
    var a = 0;	
    for (let i = 0; i < strs.length; i++) {        
        if (str == strs[i]) {
            a++;                       
            if (a > 1) return "true";
        }
    }
    return 'false';
}
console.log(str2(["a", "b", "a", "c"], "c"));
console.log(str2(["a", "b", "a", "c"], "a"));

//https://pt.stackoverflow.com/q/91760/101
