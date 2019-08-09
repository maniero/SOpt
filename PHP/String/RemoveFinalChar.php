if (isset($_POST['checkbox'])) {
    foreach ($_POST['checkbox'] as $key => $value) {
        $id = mysql_real_escape_string($value);
        $regra = "'{$id}',";
        echo $regra;       
    }
    rtrim($regra, ',');
}

//https://pt.stackoverflow.com/q/53331/101
