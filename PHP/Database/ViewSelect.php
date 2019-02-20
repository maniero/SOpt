<?php
    $query = "SELECT * from clientes";
    $result = mysql_query($query);
    while($fetch = mysql_fetch_row($result)){
        echo "<p>"
        foreach ($fetch as $value)
            echo $value . " - ";
        }
        echo "</p>";
    }
?>

//https://pt.stackoverflow.com/q/45685/101
