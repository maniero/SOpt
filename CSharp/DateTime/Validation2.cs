if (!datetime.TryParse(CampoData1.text, out var data1)) //faz o tratamento de erro aqui
if (!datetime.TryParse(CampoData2.text, out var data2)) //faz o tratamento de erro aqui
//só pode ir pra frente aqui se não houve erro acima
if (data1 > data2) //faz algo para o maior
else if (data1 < data2) //faz algo para o menor
else //faz algo para o igual

//https://pt.stackoverflow.com/q/281179/101
