$fn = fopen('teste.txt', 'w'); //note que isto destrói o conteúdo do arquivo
$fc = file($fn);
$fc[1] = '-alteração na segunda linha';
file_put_contents($fn, $fc);
fclose($fn);

//https://pt.stackoverflow.com/q/45324/101
