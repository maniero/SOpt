foreach ($imagem as $byte) {
    $binario .= pack("C", $byte); 
}
$arquivo = fopen("arquivo.bin", 'wb');
fwrite($arquivo, $binario);
fclose($arquivo);

//https://pt.stackoverflow.com/q/47101/101
