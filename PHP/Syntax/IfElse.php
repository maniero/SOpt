if ($valor < 10) {
    $total += $valor
} elseif ($total < 20) {
    $total += $valor * 1.1;
} elseif ($total < 30) {
    $total += $valor * 1.2;
} else {
    $total += $valor * 1.3;
}

if ($valor < 10) {
    $total += $valor
}
if ($total < 20) {
    $total += $valor * 1.1;
}
if ($total < 30) {
    $total += $valor * 1.2;
}
if ($total >= 30) {
    $total += $valor * 1.3;
}

if ($valor < 10) {
    $total += $valor
} else {
    if ($total < 20) {
        $total += $valor * 1.1;
    } else {
        if ($total < 30) {
            $total += $valor * 1.2;
        } else {
            if ($total >= 30) {
                $total += $valor * 1.3;
            }
        }
    }
}

//https://pt.stackoverflow.com/a/57792/101
