global $_DELETE = array();
global $_PUT = array();

if (!strcasecmp($_SERVER['REQUEST_METHOD'], 'DELETE')) {
    parse_str(file_get_contents('php://input'), $_DELETE);
}
if (!strcasecmp($_SERVER['REQUEST_METHOD'], 'PUT')) {
    parse_str(file_get_contents('php://input'), $_PUT);
}

include_once('newVerbs.php')
echo $_PUT['email']

//https://pt.stackoverflow.com/q/172109/101
