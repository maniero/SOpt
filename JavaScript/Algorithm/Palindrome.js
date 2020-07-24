function checkPalindrome(str) {     
    for(var i = 0; i < str.length / 2; i++) if (str[i] != str[str.length - i - 1]) return false;
    return true;
}
console.log(checkPalindrome("radar"));
console.log(checkPalindrome("reviver"));
console.log(checkPalindrome("palindromo"));

//https://pt.stackoverflow.com/q/315456/101
