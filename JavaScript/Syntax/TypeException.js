try {
    myroutine(); // pode lançar umas das três exceções abaixo
} catch (e if e instanceof TypeError) {
    // código que manipula a exceção TypeError
} catch (e if e instanceof RangeError) {
    // código que manipula a exceção RangeError
} catch (e if e instanceof EvalError) {
    // código que manipula a exceção EvalError
} catch (e) {
    // código que manipula exceções não especificadas
    logMyErrors(e); // passa o obejto da exceção para um manipular
}

//Você pode obter resultado semelhante de forma padrão:

try {
    myroutine(); // pode lançar umas das três exceções abaixo
} catch (e) {
    if (e instanceof TypeError) {
       // código que manipula a exceção TypeError
    } else if (e instanceof RangeError) {
       // código que manipula a exceção RangeError
    } else if (e instanceof EvalError) {
       // código que manipula a exceção EvalError
    } else {
       // código que manipula exceções não especificadas
       logMyErrors(e); // passa o obejto da exceção para um manipular
    }
}

//https://pt.stackoverflow.com/q/33876/101
