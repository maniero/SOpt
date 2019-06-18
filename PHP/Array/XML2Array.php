function XML2Array($xmlContent, $out = array()){
    $xmlObject = is_object($xmlContent) ? $xmlContent : simplexml_load_string($xmlContent);
    foreach((array) $xmlObject as $index => $node)
        $out[$index] = ( is_object($node) || is_array($node) ) ? XML2Array( $node ) : $node;
    return $out;
}

$page = file_get_contents("http://api.elsevier.com/content/search/index:SCIDIR?query=heart+attack&apiKey=CHAVEAQUI&xml-decode=true&httpAccept=application%2Fxml");
$array = XML2Array($page);

//https://pt.stackoverflow.com/q/47609/101
