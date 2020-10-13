$conn= mysqli_connect(...);
$res = mysqli_query($conn, $query);
$results = array();
while ($row = mysqli_fetch_assoc($res)) {
    $results[] = $row;
}

$conn = new MySQLi(...);
$res = $conn->query($query);
$results = array();
while ($row = $conn->fetch_assoc($res)) {
    $results[] = $row;
}

class GetResults { //poderia ter outras coisas aqui
    public function getResults() {
        $conn = new MySQLi(...);
        $res = $conn->query($query);
        $results = array();
        while ($row = $conn->fetch_assoc($res)) {
            $results[] = $row;
        }
        return $results;
    }
}

class GetResults extends Results { //tem um monte de coisa pronta em Results
    public function getResults() { //Results já tem um getResults pronto, este substituiu
        $res = $conn->query($query); //notou que conn existe em outro escopo?
        $results = array();
        while ($row = $conn->fetch_assoc($res)) {
            $results[] = $row;
        }
        return $results;
    }
}

//https://pt.stackoverflow.com/q/108047/101
