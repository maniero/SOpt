switch (Banco.Codigo) {
    case 1:
        descricaoCarteira = new Carteira_BancoBrasil(carteira).Codigo;
        break;
    case 353:
    case 8:
    case 33:
        descricaoCarteira = new Carteira_Santander(carteira).Codigo;
        break;
    case 104:
        descricaoCarteira = new Carteira_Caixa(carteira).Codigo;
        break;
    case 341:
        descricaoCarteira = new Carteira_Itau(carteira).Codigo;
        break;
    default:
        throw new Exception($"A descrição para o banco {Boleto.Banco} não foi implementada."));
        throw new Exception($"A descrição da carteira {carteira} / banco {Banco.Codigo} não foi implementada (marque false na propriedade MostrarCodigoCarteira)"));
}

//https://pt.stackoverflow.com/q/78256/101
