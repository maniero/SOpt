} catch (SenhaNaoNumericaException) {
    WriteLine("A senha não é numérica");
} catch (SenhaMuitoPequenaException) {
    WriteLine("Senha não numérica.");
} catch (SenhaInicioAbaixoDe4Exception) {
    WriteLine("Não pode começar com número abaixo de 4.");
} catch (SenhaSemCaractereEspecialException) {
    WriteLine("Não foi encontrado nenhum caractere especial");
}

catch (Exception ex) when (ex is IOException || 
                           ex is UnauthorizedAccessException || 
                           ex is NotSupportedException || 
                           ex is SecurityException || 
                           ex is DirectoryNotFoundException || 
                           ex is PathTooLongException) {
    WriteLine("deu erro");
}

//https://pt.stackoverflow.com/q/515533/101
