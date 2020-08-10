$msg = "teste";
$myfile = fopen("lista.txt", "a");
fwrite($myfile, $msg."\n");
fclose($myfile);

//https://pt.stackoverflow.com/q/335105/101
