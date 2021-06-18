while ($row = mysqli_fetch_assoc($result)) {
    $html .= $row;
}

do {
    //executa algo
} ($condicao);

while (true) {
    //executa algo
    if (!$condicao) {
        break;
    }
}

for ($i = 0; $i < 10; $i++)

for ($i = 0; // inicialização, executa apenas uma vez
     $i < 10; //condição é avaliada em cada passo da repetição, antes de iniciar o bloco
     $i++) //execução de passo

$i = 0;
while ($i < 10) {
    //executa algo
    i++;
}

$i = 0;
while ($i < 10) {
    //executa algo
    if (alguma condição) {
        continue; //o incremento não será executado, no for seria
    }
    i++;
}

for (;;) { //faz algo aqui e deve ter um if com break }

for ($x = 1, $y = 1; $x <= 10; $x++, $y++) {
    if (($y % 2) == 0) {
        $impar += $y;
    }
    $total += $x;
}

$cores = array("azul", "amarelo", "verde", "vermelho");
foreach ($cores as $cor) {
    echo "$cor<br>";
}

$cores = array("azul", "amarelo", "verde", "vermelho");
for ($i = 0; i < count($cores); i++) {
    echo "$cores[$i]<br>"; //note o índice sendo usado
}

$cores = array("azul", "amarelo", "verde", "vermelho");
$i = 0;
while (i < count($cores)) {
    echo "$cores[$i]<br>";
    $i++;
}
                         
//https://pt.stackoverflow.com/q/157512/101
