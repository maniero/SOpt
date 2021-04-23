function verificar() {
    var cpf = document.getElementById("cpf").value.substring(7, 8);
    if (cpf == "0") alert("Rio Grande do Sul");
    else if (cpf == "1") alert(" Distrito Federal – Goiás – Mato Grosso – Mato Grosso do Sul – Tocantins ");
    else if (cpf == "2") alert("  Pará – Amazonas – Acre – Amapá – Rondônia – Roraima");
    else if (cpf == "3") alert(" Ceará – Maranhão – Piauí");
    else if (cpf == "4") alert(" Pernambuco – Rio Grande do Norte – Paraíba – Alagoas ");
    else if (cpf == "5") alert(" Bahia – Sergipe   ");
    else if (cpf == "6") alert("Minas Gerais ");
    else if (cpf == "7") alert("Rio de Janeiro – Espírito Santo");
    else if (cpf == "8") alert("São Paulo");
    else if (cpf == "9") alert("Paraná – Santa Catarina");
}

//https://pt.stackoverflow.com/q/415060/101

<p>Informar CPF</p><input type = "text" id = "cpf">
 <input type = "button" id = "opcao" name = "opcao" value = "Verificar" onclick = "verificar()"><br>
