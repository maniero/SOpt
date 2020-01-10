$file = fopen("teste.txt",'rb');
$count = 0;
while (!feof($file)) {
    $chunk= fread($f, 4096); //provavelmente eu colocaria um valor maior, jamais menor
    $count += substr_count($chunk, "\n");
}
fclose($file);

//https://pt.stackoverflow.com/q/128387/101
