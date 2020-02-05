if (!is_numeric($num1) || !is_numeric($num2) {
    echo "ERRO: as entradas precisam ser numéricas";
    //encerra de alguma forma, dpende do código.
}
$num1 = intval($num1); //pode  ser um floatval
$num2 = intval($num2);
switch ($operator) {
    case '+':
        $result = $num1 + $num2;
        break;
    case '-':
        $result = $num1 - $num2;
        break;
    case '*':
        $result = $num1 * $num2;
        break;
    case '/':
        if ($num2 == 0) {
            echo "ERRO: Não pode fazer divisão por zero";
            break;
        }
        $result = $num1 / $num2;
        break;
    default:
        //talvez mereça alguma mensagem de erro se não for nenhum operador válido
}
echo "O resultado é: " . $result;

//https://pt.stackoverflow.com/q/139313/101
