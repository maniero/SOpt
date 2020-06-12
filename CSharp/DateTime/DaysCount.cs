try {
    var dataAtual = new DateTime(Convert.ToInt32(txtDia.Text), Convert.ToInt32(txtMes.Text), Convert.ToInt32(txtAno.Text));
    lblData.Text = "DATA VÁLIDA";
    lblData.ForeColor = System.Drawing.Color.Blue;
} catch (ArgumentOutOfRangeException ex) {
    lblData.Text = "DATA INVÁLIDA";
    lblData.ForeColor = System.Drawing.Color.Red;
}

if (DateTime.TryParseExact($"{Convert.ToInt32(txtDia.Text)}/{ Convert.ToInt32(txtMes.Text)}/{Convert.ToInt32(txtAno.Text)}", "dd/MM/yyyy",
CultureInfo.InvariantCulture, DateTimeStyles.None, out var dataAtual);
    lblData.Text = "DATA VÁLIDA";
    lblData.ForeColor = System.Drawing.Color.Blue;
} else {
    lblData.Text = "DATA INVÁLIDA";
    lblData.ForeColor = System.Drawing.Color.Red;
}

static int ContarDias(DateTime dataAtual) => (dataAtual - new DateTime(dataAtual.Year, 1, 1)).Days;

//https://pt.stackoverflow.com/q/235203/101
