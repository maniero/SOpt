int soma = 0;
for (int i = 0; i < Convert.ToInt32(qtdD6.Text); i++ ) {
    soma += rnd.Next(1, 7);
}
resultadoD6.Text = soma.ToString();

//Alternativa

var qtde = Convert.ToInt32(qtdD6.Text)
resultadoD6.Text = (rnd.Next(qtde, qtde * 6 + 1)).ToString();

//https://pt.stackoverflow.com/q/218898/101
