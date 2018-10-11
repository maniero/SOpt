<?php
function pluralization($numItems = 0, $texts = NULL) {
	if ($texts == NULL) $texts = array("(nenhum)", "(1 item)", "($numItems itens)");
    return $texts[min($numItems, 2)];
}
echo pluralization(0);
echo pluralization(0);
echo pluralization(1);
echo pluralization(2);
echo pluralization(3);
$elementos = 4;
echo pluralization($elementos, ["nada", "um elemento", "$elementos elementos"]);

//https://pt.stackoverflow.com/q/42711/101
