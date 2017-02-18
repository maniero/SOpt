<?php
    ob_start();
    echo "1 : Hello\n";
    ob_start();
    echo "2 : Hello";
    var_dump(ob_get_clean());
    echo "3 : Hello";
?>

//http://pt.stackoverflow.com/q/184952/101
