function trocar(){
  valor = document.getElementById('btnTrocar').innerHTML;
  console.log(valor);
  if(valor == "Imagem ˅"){
    document.getElementById("btnTrocar").innerHTML = "Imagem  &#706;";
    alert("Texto 1");
  }
  else{
    document.getElementById("btnTrocar").innerHTML = "Imagem  &#709;";
    alert("Texto 2");
  }
}

<button onclick="trocar()" id="btnTrocar">Imagem &#709;</button>

//https://pt.stackoverflow.com/q/327855/101
