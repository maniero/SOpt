$query = mysqli_prepare($db, "UPDATE `char` SET aparencia = '1' WHERE account_id = ?");
mysqli_stmt_bind_param($query, $_GET['id']);
mysqli_stmt_execute($query);

<p style="margin-top: 0; margin-bottom: 0"><font face="Verdana" color="#009900" size="3">
    <a href="mostraitem.php?id=' . $linha['account_id']. '>'.$name.'</a></font></p></td>

//https://pt.stackoverflow.com/q/56726/101
