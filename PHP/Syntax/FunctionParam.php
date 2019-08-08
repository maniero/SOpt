 <?php
function dobrar_array($dobrar){
    foreach($dobrar as $lista){
        echo $lista*2 . "<br>";
    }
}
$resposta = dobrar_array(array(3, 15, 23));
echo $resposta;

//https://pt.stackoverflow.com/q/52903/101
