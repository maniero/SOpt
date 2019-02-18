$resultado = mysqli_query("SELECT texto FROM tabela");
$contagem = array();
while ($linha = mysqli_fetch_array($resultado)) {
    $palavras = str_word_count($linha, 1);
    foreach($palavras AS $palavra) $contagem[$palavra]++;
}
arsort($contagem);
$i = 0;
foreach($contagem AS $key => $value) {
    echo $value . " => " . $key . "\n";
    $i++;
    if ($i >= 3) break;
}

//https://pt.stackoverflow.com/q/45464/101
