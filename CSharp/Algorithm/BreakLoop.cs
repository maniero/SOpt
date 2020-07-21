Write("Nome da moto:");
var nomeMoto = ReadLine();
var cadastrada = false;
foreach (var veiculo in ListaDeVeiculos) {
    if (nomeMoto == veiculo.NomeMoto) {
        Write($"Preço {veiculo.Preco:C");
        cadastrada = true;
        break;
    }
}
if (!cadastrada) Write("Moto não cadastrada!");

//https://pt.stackoverflow.com/q/300305/101
