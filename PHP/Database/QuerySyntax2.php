$stmt = $mysqli->prepare("SELECT * FROM tabela WHERE username = ? OR username = ?");
$stmt->bind_param('ss', $userName, $userName);

$query = "SELECT * FROM tabela WHERE username = $userName";

$stmt = $pdo->prepare("SELECT * FROM tabela WHERE username = :user OR username = :user");
$stmt->bindParam(':user', $userName);

//https://pt.stackoverflow.com/q/22621/101
