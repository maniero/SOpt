function trimSpecials(text, chars) {
    var result = '';
    for (var i = 0; i < text.length; i++) {
        var isNormal = true;
        for (var j = 0; j < text.length; j++) {
            if (text[i] == chars[j]) {
                isNormal = false;
                break;
            }
        }
        if (isNormal) result += text[i];
    }
    return result;
}

function ellipsis(text, length, ellipsis) {
    ellipsis = typeof ellipsis !== 'undefined' ? ellipsis : '...';
    if (text.length <= length) return text;
    if (length <= ellipsis.length) return ellipsis.substr(0, length);
    text = text.substr(0, length - ellipsis.length);
    var position = text.lastIndexOf(' ');
    position = position < 0 ? 0 : position;
    return trimSpecials(text.substr(0, position), ['.', ',', ';', ':', '!', '?'])  + ellipsis;
}

var texto = "Este é um teste de texto longo que precisa ser truncado com reticências, sem cortar a palavra.";
for (var i = 0; i < texto.length + 1; ++i) console.log(i + ' : ' + ellipsis(texto, i));

//https://pt.stackoverflow.com/q/155204/101
