if (email == null || email.equals("")) {

if (validaDiaDaData(dataNasc))
if (dataNasc == null || dataNasc.equals("")
        || !validaIntervalosDeData(dataNasc))

String[] dia = data.split("/");
if (dia[0].length() > 2)
    return true;
return false;

String[] dia = data.split("/");
return dia[0].length() > 2;

//https://pt.stackoverflow.com/q/92591/101
