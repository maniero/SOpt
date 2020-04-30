function Avaliar_checkbox() {
    var livros = document.getElementById("livros");
    var folhas = document.getElementById("folhas");
    var porta = document.getElementById("porta");
    if (livros.checked && folhas.checked && porta.checked) alert('Livros, folhas e porta');
    else if (livros.checked && porta.checked) alert('Livros e Porta');
    else if (livros.checked) alert('livros');
    else if (folhas.checked) alert('folhas');
    else if (porta.checked) alert('porta');
}
<input type="checkbox" class="check"  id="livros" value="livros"/>
<input type="checkbox" class="check" id="folhas" value="folhas"/>
<input type="checkbox" class="check" id="porta" value="porta"/>

<a href="#" class="botao" onclick="Avaliar_checkbox()">Avaliar</a>

//https://pt.stackoverflow.com/q/185525/101
