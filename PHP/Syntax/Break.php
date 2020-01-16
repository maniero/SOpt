for ($letter = 0; $letter < count($keyArray) && filter_var($keyArray[$letter], FILTER_VALIDATE_INT); $letter++) {
    $contNumber++;
}

foreach ($keyArray as $letter) {
    if (filter_var($letter, FILTER_VALIDATE_INT))
        $contNumber++;
    else
        break;
}

foreach ($keyArray as $letter) {
    if (!filter_var($letter, FILTER_VALIDATE_INT))
        break;
    $contNumber++;
}

//https://pt.stackoverflow.com/q/131093/101
