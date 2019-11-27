$operacao = 'somar';
$valor1 = 5;
$valor2 = 10;
$saldo = null;
$saldo = $valor1 + $valor2 * ($operacao == 'somar' ? 1 : -1);
if ($saldo != null) echo $saldo;

$saldo = $valor1 + ($operacao == 'somar' ? $valor2 : -$valor2);

function InvertSignalConditional($value, $condition) {
    return $condition ? -$value, $value)
}

//https://pt.stackoverflow.com/q/110105/101
