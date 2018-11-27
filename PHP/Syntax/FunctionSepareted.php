<?php include 'sessaoBD.php' ?>
<!DOCTYPE html>
<html lang="en" dir="ltr">
<head>
  <title>Trabalho web</title>
  <meta charset="utf-8">
  <link rel="stylesheet" type="text/css" href="css/style_hashbase.css">
  <script src="js/jquery-3.2.1.min.js"></script>
  <script src="js/bootstrap.js"></script>
</head>
<body>
<?php include 'header.html' ?>
  <div id="content">
    <div id="page">
      <div id="list">
         <div id="post">
         <?php if ($login and $_SESSION["user_name"] === "lucas"): ?>
             <a href="crianewpost.php">*NEW POST*</br></br></a>
         <?php endif;
         getPosts();
         ?>
         </div>
       </div>
     </div>
   </div>
</body>
</html>

Postagens.php

<?php
function getPosts() {
    $sql =  "select titulo, id from POSTS";
    $result = $conn->query($sql);
    if ($conn->query($sql) === false) echo "Error: " . $sql . "<br>" . $conn->error;
    if ($result->num_rows > 0) {
        while ($row = $result->fetch_assoc()) {
            echo  '<a method="get" href= "db/seleposts.php?posts_id='.$row['id'].'">'.$row["titulo"].'</a> <br>';
        }
    } else echo "0 results";
}
?>

//https://pt.stackoverflow.com/q/345928/101
