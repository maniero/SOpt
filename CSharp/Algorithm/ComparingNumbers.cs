private void _Random_Click(object sender, EventArgs e) {
    var num = new Random();
    int valMin;
    if (int.TrypParse(_TextValMin.Text, out valMin)) {
        MessageBox.Show("valor inválido"); //obviamente isto é uma simplificação
        return;
    }
    int valMax;
    if (int.TrypParse(_TextValMax.Text, out valMax)) {
        MessageBox.Show("valor inválido"); //obviamente isto é uma simplificação
        return;
    }
    var valSorteado = num.Next(valMin, valMax);
    _ValSorteado.Text = valSorteado.ToString();
    int valPalpite;
    if (int.TrypParse(_TextValPalpite.Text, out valPalpite)) {
        MessageBox.Show("valor inválido"); //obviamente isto é uma simplificação
        return;
    }
    if (_Igual.Checked) {
        if (valPapite == valSorteado) _Acerto.Text = (++_adicionar).ToString();
        else _Errou.Text = (++_retirar).ToString();
        if (_Maior.Checked) {
            if (valPalite > valSorteado) _Acerto.Text = (++_adicionar).ToString();
            else _Errou.Text = (++_retirar).ToString();
         }
         if (_Menor.Checked) {
            if (valPalite < valSorteado) _Acerto.Text = (++_adicionar).ToString();
            else _Errou.Text = (++_retirar).ToString();
            }
        }
    }
}

//https://pt.stackoverflow.com/q/129410/101
