<?php
set_error_handler('error_handler');

function error_handler($errno, $errstr, $errfile, $errline, $errcontext) {
    // Get the correct string for the error type
    switch($errno){
        case E_ERROR:
            $type = 'Error';
            break;
        case E_WARNING:
            $type = 'Warning';
            break;
        case E_PARSE:
            $type = 'Parse Error';
            break;
        case E_NOTICE:
            $type = 'Notice';
            break;
        case E_CORE_ERROR:
            $type = 'Core Error';
            break;
        case E_CORE_WARNING:
            $type = 'Core Warning';
            break;
        case E_COMPILE_ERROR:
            $type = 'Compile Error';
            break;
        case E_COMPILE_WARNING:
            $type = 'Compile Warning';
            break;
        case E_USER_ERROR:
            $type = 'User Error';
            break;
        case E_USER_WARNING:
            $type = 'User Warning';
            break;
        case E_USER_NOTICE:
            $type = 'User Notice';
            break;
        case E_STRICT:
            $type = 'Strict Notice';
            break;
        case E_RECOVERABLE_ERROR:
            $type = 'Recoverable Error';
            break;
        default:
            $type = 'Unknown error (' . $errno . ')';
            break;
    }

    // translate text
    $type = error_handler_translate($type);
    $str = error_handler_translate($errstr);
    $in = error_handler_translate('in');
    $line = error_handler_translate('on line');

    // echo the error in "default" PHP format
    echo '<br /><b>'. $type .':</b> ' . $str . ' '. $in .' <b>' . $errfile . '</b> '. $line .' <b>' . $errline . '</b><br />';

    // ignore the original PHP error handling
    return true;
}

function error_handler_translate($str) {
    // translate $str here

    return $str;
}

//https://pt.stackoverflow.com/q/77935/101
