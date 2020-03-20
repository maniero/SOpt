function chkVitoria() {
    return ((chkSrc('0') == chkSrc('1')) && (chkSrc('0') == chkSrc('2')) && chkSrc('0') != 'branco.png') ||
           ((chkSrc('3') == chkSrc('4')) && (chkSrc('3') == chkSrc('5')) && chkSrc('3') != 'branco.png') ||
           ((chkSrc('6') == chkSrc('7')) && (chkSrc('6') == chkSrc('8')) && chkSrc('6') != 'branco.png') ||
           ((chkSrc('0') == chkSrc('3')) && (chkSrc('0') == chkSrc('6')) && chkSrc('0') != 'branco.png') ||
           ((chkSrc('1') == chkSrc('4')) && (chkSrc('1') == chkSrc('7')) && chkSrc('1') != 'branco.png') ||
           ((chkSrc('2') == chkSrc('5')) && (chkSrc('2') == chkSrc('8')) && chkSrc('2') != 'branco.png') ||
           ((chkSrc('0') == chkSrc('4')) && (chkSrc('0') == chkSrc('8')) && chkSrc('0') != 'branco.png') ||
           ((chkSrc('2') == chkSrc('4')) && (chkSrc('2') == chkSrc('6')) && chkSrc('2') != 'branco.png');
};

//https://pt.stackoverflow.com/q/165868/101
