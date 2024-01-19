function getText() {
  input = document.getElementById('campo') //pega o elemento
  console.log(input.value); //pega o valor do elemento
}
<input type = "text" value = "texto aqui" id = "campo"/>
<input type = "button" value = "ok" onclick="getText();"/>

<input type = "text" value = "texto aqui" id = "campo"/>
<input type = "button" value = "ok" onclick="console.log(document.getElementById('campo').value);"/>

//https://pt.stackoverflow.com/q/134616/101
