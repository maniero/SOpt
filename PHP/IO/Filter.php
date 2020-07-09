$dirtmp = "fotos/tmp";
$ditmp = new RecursiveDirectoryIterator($dirtmp, FilesystemIterator::SKIP_DOTS);
$ritmp = new RecursiveIteratorIterator($ditmp, RecursiveIteratorIterator::CHILD_FIRST);
foreach ($ritmp as $file) if (!endsWith($file, "zVazio.jpg")) unlink($file);

function endsWith($haystack, $needle) {
    $length = strlen($needle);
    if ($length == 0) return true;
    return (substr($haystack, -$length) === $needle);
}

$dirtmp = "fotos/tmp";
$ditmp = new RecursiveDirectoryIterator($dirtmp, FilesystemIterator::SKIP_DOTS);
$ritmp = new RecursiveIteratorIterator($ditmp, RecursiveIteratorIterator::CHILD_FIRST);
foreach ($ritmp as $file) if ($file->getFilename() != "zVazio.jpg") unlink($file);

//https://pt.stackoverflow.com/q/461346/101
