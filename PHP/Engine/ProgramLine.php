<?php
Class Example {
    function methodExample($line) {
        echo $line . "\n";
    }
    function methodExample2() {
        echo debug_backtrace()[0]["line"];
    }
}
Example::methodExample(__LINE__);
Example::methodExample2();

//https://pt.stackoverflow.com/q/138370/101
