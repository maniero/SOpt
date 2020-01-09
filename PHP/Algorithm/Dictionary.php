$palavras = array(
    "oi" => 09368,
    "tchau"   => 01234,
    "palavra" => 34986,
    "abobrinha" => 72494);
$codigo = $palavras["oi"]; //busca rápida
$palavra = array_search(01234, $palavras); //busca lenta

$palavras = array(
    09368 => "oi",
    01234 => "tchau",
    34986 => "palavra",
    72494 => "abobrinha");
    
//https://pt.stackoverflow.com/q/127804/101
