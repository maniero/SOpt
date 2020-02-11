function calcular() {
    var media = (Number(window.document.getElementById('nt1').value) +
    Number(window.document.getElementById('nt2').value) +
    Number(window.document.getElementById('nt3').value) +
    Number(window.document.getElementById('nt4').value)) / 4;
    window.document.getElementById('res').innerHTML = `Resultado: ${media >= 6 ? 'Aprovado' : 'Reprovado'}`;
}
calcular();
<input id="nt1" value="1">
<input id="nt2" value="2">
<input id="nt3" value="3">
<input id="nt4" value="4">
<div id="res">

//https://pt.stackoverflow.com/q/435160/101
