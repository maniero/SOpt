public string RAMU_TIE() {
    return (Program.HardwareInfo.RAM() - RAM_TIE()).ToString();
}

public int RAM_TIE() {
    return ram.NextValue();
}

(ram.NextValue() - ramTie.NextValue()).ToString();

//https://pt.stackoverflow.com/q/97903/101
