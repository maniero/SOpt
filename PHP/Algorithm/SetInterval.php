function setInterval($callback, $milliseconds) {
    $seconds = (int)$milliseconds / 1000;
    while (true) {
        $callback();
        sleep($seconds);
    }
}

//https://pt.stackoverflow.com/q/157451/101
