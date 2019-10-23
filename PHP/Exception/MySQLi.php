$query = $db->prepare("ppapapa sql sql");
try {
    $query -> execute();
    return $query -> fetchAll();
} catch(mysqli_sql_exception $e) {
    die($e -> getMessage());
}

if (!mysqli->query($insadquery)) die(mysqli->errno . " - " . $mysqli->error);

//https://pt.stackoverflow.com/q/93080/101
