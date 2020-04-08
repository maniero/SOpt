header('HTTP/1.1 301 Moved Permanently');
header('Location: http://www.example.com');

header('HTTP/1.1 503 Service Temporarily Unavailable');
header('Status: 503 Service Temporarily Unavailable');
header('Retry-After: 60');

header('Content-Type: image/png');

header('Expires: Sat, 26 Jul 1997 05:00:00 GMT');
header('Cache-Control: no-store, no-cache, must-revalidate');
header('Cache-Control: pre-check=0, post-check=0, max-age=0');
header ('Pragma: no-cache');

header('Content-Disposition: attachment; filename=' . urlencode($file));   
header('Content-Type: application/force-download');
header('Content-Type: application/octet-stream');
header('Content-Type: application/download');
header('Content-Description: File Transfer');            
header('Content-Length: ' . filesize($file));
echo file_get_contents($file);

header('Content-Type: application/octet-stream');
header('Content-Disposition: attachment; filename="plain_text_file.txt"');

header('WWW-Authenticate: Basic realm="The Realm"');
header('HTTP/1.0 401 Unauthorized');

//https://pt.stackoverflow.com/q/175927/101
