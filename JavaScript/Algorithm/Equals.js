var numbers = '1111121111';
console.log('numbersEquals = ' + (numbers.replace(new RegExp(numbers.substr(0, 1), 'g'), "").length == 0));
numbers = '1111111111';
console.log('numbersEquals = ' + (numbers.replace(new RegExp(numbers.substr(0, 1), 'g'), "").length == 0));

//https://pt.stackoverflow.com/q/172410/101
