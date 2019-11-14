<?php
function capitalize($string, $search = array("De ", "Do ", "Dos ", "Da ", "Das "), $replace = array("de ", "do ", "dos ", "da ", "das ")) {
	return str_replace($search, $replace, ucwords(strtolower($string)));
}
echo capitalize("PORTO DE GALINHAS") . "\n";
echo capitalize("joão da silva") . "\n";
echo capitalize("joão da silva", array("De"), array("de")) . "\n";
echo capitalize("PORTO DE GALINHAS", array(), array()) . "\n";
echo capitalize("star wars episódio III - a vingança dos sith",
    array("De ", "Do ", "Dos ", "Da ", "Das ", "I ", "Ii ", "Iii ", "Iv ", "V ", "Vi ", "Vi "),
    array("de ", "do ", "dos ", "da ", "das ", "I ", "II ", "III ", "IV ", "V ", "VI ", "VI ")) . "\n";
    
//https://pt.stackoverflow.com/q/105683/101
