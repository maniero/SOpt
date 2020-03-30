if (form1.autonomoBonusBruto.value.includes("R$")){
    form1.autonomoBonusBruto.value = form1.autonomoBonusBruto.value.replace("R$", "");
    alert(form1.autonomoBonusBruto.value);
}
<form name = "form1">
    <input name = "autonomoBonusBruto" value = "R$">
</form>

//https://pt.stackoverflow.com/q/171595/101
