<form name="questao1" method="post" onsubmit=""> 
    <br><input type="checkbox" name="Q1[]" value="Enfermagem" onclick="getPontos(1)"> Garantir a saúde das pessoas 
    <br><input type="checkbox" name="Q1[]" value="Eletroeletronica" onclick="getPontos(2)"> Máquinas e instalações elétricas 
    <br><input type="checkbox" name="Q1[]" value="Informatica" onclick="getPontos(3)"> Usar lógica para fazer programas e sistemas
    <br><input type="checkbox" name="Q1[]" value="Alimentos" onclick="getPontos(4)"> Desenvolver, gerenciar e distribuir produtos alimenticios
    <br><input type="checkbox" name="Q1[]" value="Plasticos" onclick="getPontos(5)"> Desenvolver, gerenciar e distribuir produtos plásticos
    <br><input type="checkbox" name="Q1[]" value="Logistica" onclick="getPontos(6)"> Desenvolver, gerenciar e distribuir produtos
    <br><input type="checkbox" name="Q1[]" value="Administracao" onclick="getPontos(7)"> Gerenciar e influenciar pessoas a atingirem metas
    <br><input type="checkbox" name="Q1[]" value="Quimica" onclick="getPontos(8)"> Estudar, manusear e transformar substâncias ou materiais
    <br><input type="checkbox" name="Q1[]" value="Meio_Ambiente" onclick="getPontos(9)"> Estudar, manusear e transformar substâncias ou materiais da natureza
    <br><input type="checkbox" name="Q1[]" value="Mecatronica" onclick="getPontos(10)"> Projetar, usar, instalar e controlar máquinas industriais
    <br><input type="checkbox" name="Q1[]" value="Eletronica" onclick="getPontos(11)"> Sistemas  e aparelhos eletrônicos
    <br><input type="checkbox" name="Q1[]" value="Telecomunicacao" onclick="getPontos(12)"> Sistemas e aparelhos de comunicação
    <br><input type="checkbox" name="Q1[]" value="Seguranca" onclick="getPontos(13)"> Instruir e garantir a segurança das pessoas e locais
    <br><br><input type="submit" value="Próximo" onclick="finalizar()">     
</form>

var arrayPontos = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
function arrayPositionMax(array) {
    var max = -Infinity;
    var position = -Infinity;
    for (i = 0; i != array.length; ++i) {
        if (array[i] > max) {
            max = array[i];
            position = i;
        }
    }
    return position;
}
function getPontos(pontos){
    arrayPontos[pontos]++;
}      
function finalizar(){  
    alert(["Enfermagem", "Eletroeletronica", "Informatica", "Alimentos", "Plasticos", "Logistica", "Administracao", "Quimica", "Meio_Ambiente", "Mecatronica", "Eletronica", "Telecomunicacao", "Seguranca"][arrayPositionMax(arrayPontos) - 1]); 
}

//https://pt.stackoverflow.com/q/169503/101
