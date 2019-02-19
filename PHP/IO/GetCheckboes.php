<form action="index.php" method="post">
<input type="checkbox" id="newsconf"  name="newsconf" value="1"/>
<input type="submit" name="submit" value="Ok"/>
</form>

<?php
if(isset($_POST['newsconf']) && $_POST['newsconf'] == '1') {
    echo "checkado";
} else {
    echo "não checkado";
}    
?>

//https://pt.stackoverflow.com/q/45610/101
