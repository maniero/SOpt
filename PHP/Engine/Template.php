$template=file_get_contents('template.php');
$re = "/%(\\w*?)%/"; 
$subst = "<?php $1(); ?>"; 
$result = preg_replace($re, $subst, $template);
file_put_contents('template.php',$result);

//https://pt.stackoverflow.com/q/220996/101
