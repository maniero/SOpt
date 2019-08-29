<?php
function geraSenha() {
	//caracteres que serão usados na senha randomica
	$chars = 'abcdxyswzABCDZYWSZ0123456789';
	//ve o tamnha maximo que a senha pode ter
	$max = strlen($chars) - 1;
	//declara $senha
	$senha = null;
	
	//loop que gerará a senha de 8 caracteres
	for ($i=0;$i < 8; $i++) {
		$senha .= $chars{mt_rand(0,$max)};
	}
	return $senha;          
}
$i = 0;
while ($i < 10) {
	echo geraSenha() . "\n";
	$i++;
}

//https://pt.stackoverflow.com/q/56732/101
