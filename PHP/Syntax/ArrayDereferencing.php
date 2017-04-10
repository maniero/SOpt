$x = 1;

echo ['stack', 'overflow'][$x];

//é "melhor" (ou pelo menos o código fica mais simplificado) que fazer

switch ($x) {
    case 0: 
        echo 'stack';
        break;
    case 1:
        echo 'overflow';
        break;
}

//http://pt.stackoverflow.com/q/23400/101
