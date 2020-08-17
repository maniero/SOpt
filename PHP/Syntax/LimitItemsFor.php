$images = glob($dirname."*.{jpg,jpeg,png,gif,JPG,PNG,JPEG,GIF}",GLOB_BRACE);
for ($i = 0; count($images); $i++) {
    echo '
<a href="'.$images[i].'" data-at-1920="'.$images[i].'">

$images = glob($dirname."*.{jpg,jpeg,png,gif,JPG,PNG,JPEG,GIF}",GLOB_BRACE);
$i = 0;
foreach($images as $image) {
    echo '
<a href="'.$image.'" data-at-1920="'.$image.'">
...
if (++$i > 4) break;

$images = glob($dirname."*.{jpg,jpeg,png,gif,JPG,PNG,JPEG,GIF}",GLOB_BRACE);
foreach($images as $key => $image) {
    echo '
<a href="'.$image.'" data-at-1920="'.$image.'">
...
if ($key > 4) break;

$images = array_slice(glob($dirname."*.{jpg,jpeg,png,gif,JPG,PNG,JPEG,GIF}",GLOB_BRACE), 4);
foreach($images as $image) {
    echo '
<a href="'.$image.'" data-at-1920="'.$image.'">

//https://pt.stackoverflow.com/q/344751/101
