$sql4 = mysqli_query($db, "SELECT account_id, userid, sex, email, group_id, last_ip, unban_time, diasvip, cash2 FROM login ORDER BY account_id WHERE userid = '$userid'");
$exibe4 = mysqli_fetch_assoc($sql4);
$_SESSION['account_id'] = $exibe4['account_id'];
$_SESSION['userid'] = $exibe4['userid'];
$_SESSION['sex'] = $exibe4['sex'];
$_SESSION['email'] = $exibe4['email'];
$_SESSION['group_id'] = $exibe4['group_id'];
$_SESSION['last_ip'] = $exibe4['last_ip'];
$_SESSION['unban_time'] = $exibe4['unban_time'];
$_SESSION['diasvip'] = $exibe4['diasvip'];
$_SESSION['cash2'] = $exibe4['cash2'];

$_SESSION['verdados'] = $exibe4;

echo ' '.$_SESSION['verdados']['account_id'].' ';
// ... continua aqui para todas as colunas

//https://pt.stackoverflow.com/q/55256/101
