$database = date_create('2018-07-15');
$datadehoje = date_create();
$resultado = date_diff($database, $datadehoje);
echo date_interval_format($resultado, '%a');

//https://pt.stackoverflow.com/q/320027/101
