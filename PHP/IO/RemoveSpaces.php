$tamanhos = { 4, 8, 2, 18 ..... };
$abrirArquivo = fopen($uploadArquivo, "r");
while(!feof($abrirArquivo)){
    $ler = fgets($abrirArquivo,460);
    $campos = array();
    $posicao = 0;
    for ($i = 0; $i < sizeof($tamanhos); $i++) {
        $campos[] = trim(substr($ler, $posicao, $tamanhos[$i]));
        $posicao += $tamanhos[$i];
    }
}
fclose($abrirArquivo);

//https://pt.stackoverflow.com/q/92619/101
