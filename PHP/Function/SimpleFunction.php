function DescricaoTipoNota($modeloNota) {
    return $modeloNota == "65" ? "NFCE" : $modeloNota == "55" ? "NFE" : null;
}

//https://pt.stackoverflow.com/q/338543/101
