if ($DocInfo->http_status_code === 200) {
    if ($DocInfo->content) {
        $html = str_get_html($DocInfo->content);
        $title = $html->find('title');
        echo $title[0]->plaintext.'<br />';
    } else {
        echo "deu erro aqui";
        //faz alguma coisa útil
    }
}

//

try { 
    if ($DocInfo->http_status_code === 200) {
        //Print Page Title
        $html = str_get_html($DocInfo->content);
        $title = $html->find('title');
        echo $title[0]->plaintext.'<br />';
    }
} catch (Exception $ex) {
    echo "deu erro aqui";
    //faz alguma coisa útil
}

//https://pt.stackoverflow.com/q/50201/101
