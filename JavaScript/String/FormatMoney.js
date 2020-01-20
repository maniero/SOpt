function moneyTextToFloat(text) { 
  var cleanText = text.replace("R$", " ").replace(",", ".");
  return parseFloat(cleanText);
}

function floatToMoneyText(value) {
  var text = (value < 1 ? "0" : " ") + Math.floor(value * 100);
  return "R$ " + text.substr(0, text.length - 2) + "," + text.substr(-2); 
}

var total = document.getElementById("total");
var mostrar = moneyTextToFloat(total.innerHTML);
alert(mostrar);
var mostrarTexto = floatToMoneyText(29.90);
alert(mostrarTexto);
<body>

  <table>
    <tbody>
      <tr>
        <td>
          <div>R$ 29,90</div>
        </td>
        <td>
          <input type="number">
        </td>
      </tr>
    </tbody>
    <tr>
      <td> </td>
      <td>Total da compra</td>
      <td><div id="total">R$ 29,90</div></td>
      <td> </td>
    </tr>
  </table>
  
//https://pt.stackoverflow.com/q/133876/101
