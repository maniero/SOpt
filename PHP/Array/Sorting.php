function cmp($a, $b) {
    if ($a == $b) return 0;
    return (substr($a, 37, 4) < substr($b, 37, 4)) ? -1 : 1;
}

$array = [
        "T3497012@CHOSTBRHDDSB@EICM_BORA@BPHS@Bamz",
        "T3497012@BHOSTBRHDDSB@EICM_BORA@BPHS@Bamz",
        "T3497012@AHOSTBRHDDSB@EICM_BORA@BPHS@Bamz",
        "T3497012@AHOSTBRHDDSB@EICM_BORB@BPHS@Aama",
        "T3497012@AHOSTBRHDDSB@EICM_BORC@APHS@cama",
        "T2497123@DHOSTBRHDDSB@CICM_BORD@APHS@camb",
        "T2497123@EHOSTBRHDDSB@BICM_BORE@APHS@camc",
        "T5557012@FHOSTBRHDDSB@AICM_BORF@APHS@camd"
      ];
usort($array, "cmp");

foreach ($array as $key => $value) {
    echo "$key: $value\n";
}

//https://pt.stackoverflow.com/q/270851/101
