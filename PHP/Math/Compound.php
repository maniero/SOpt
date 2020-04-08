$r = 0;
for ($ranking = 1; $ranking <=5; $ranking++) {
    $p = isset($_GET["n$ranking"])?$_GET["n$ranking"]:0;
    echo "$ranking ° Numero: $p";
    $r += $p;
}


$r = 1;
for ($ranking = 1; $ranking <=5; $ranking++) {
    $p = isset($_GET["n$ranking"])?$_GET["n$ranking"]:0;
    echo "$ranking ° Numero: $p";
    $r *= $p;
}

//https://pt.stackoverflow.com/q/175433/101
