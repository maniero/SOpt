inicio:
    $row = fgets($file);
    if (!$row) goto fim;
    ...
    goto inicio;
fim:

//https://pt.stackoverflow.com/q/325296/101
