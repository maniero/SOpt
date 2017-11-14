<?php
$status_os_cliente = "A";
$os = $status_os_cliente == "A" ? "SIM" : "NÃO";
echo $os;
$status_os_cliente = "B";
if ($status_os_cliente == "A") {
    $os = "SIM";
} else {
    $os = "NÃO";
}
echo $os;

//https://pt.stackoverflow.com/q/254903/101
