<?php
function post_isset($indexes) {
	foreach($indexes as $index) if (!isset($_POST[$index])) return false;
	return true;
}
if (!post_isset(['nome', 'email'])) echo "deu erro";

//https://pt.stackoverflow.com/q/58355/101
