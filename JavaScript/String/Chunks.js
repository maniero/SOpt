var str = 'stackoverflow';
var chunks = [];
for (var i = 0, charsLength = str.length; i < charsLength; i += 3) chunks.push(str.substring(i, i + 3));
for (var i = 0; i < chunks.length; i++) console.log(chunks[i]);

//https://pt.stackoverflow.com/q/146682/101
