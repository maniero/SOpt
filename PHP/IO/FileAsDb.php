$texto = implode(",", $array); //converte o array em um texto simples
$ok = file_put_contents("arquivo.txt", $texto); //grava
$texto = file_get_contents("arquivo.txt"); //lê
$array = explode(",", $texto); //transforma em array novamente

//https://pt.stackoverflow.com/q/82067/101
