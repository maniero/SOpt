function consulta1() {
  var elemento = document.getElementById('consT');
  var checado = document.getElementById('checkBA').checked;
  elemento.value = checado ? "R$ 75,00" : "";
  elemento.readOnly = true;
  elemento.disabled = checado;
}

function consulta2() {
  var elemento = document.getElementById('interT');
  var checado = document.getElementById('checkBB').checked;
  elemento.value = checado ? "R$ 510,00" : "";
  elemento.readOnly = true;
  elemento.disabled = checado;
}

function consulta3() {
  var elemento = document.getElementById('examT');
  var checado = document.getElementById('checkBC').checked;
  elemento.value = checado ? "R$ 150,00" : "";
  elemento.readOnly = true;
  elemento.disabled = checado;
}
<form><fieldset><legend><font color="darkblue">Serviços</font></legend><br>
		<table width="80%" border="0" style= "border-color: Gainsboro" cellpadding="10">
				
		<tr>
		<td>
		<input type="checkbox" name="servico1" id="checkBA" onclick='consulta1()'; > 				
		Consulta <td><input type="text"  id="consT"  size="20" maxlength="35"readonly/></td>
		</td>
		</tr>
		<tr>
		<td>
		<input type="checkbox" name="servico2" id="checkBB" onclick='consulta2()'; />
	Internação <td><input type="text" id="interT" size="20" maxlength="35" readonly/></td>
		</td>
		</tr>
		<tr>
		<td>
		<input type="checkbox" name="servico3" id="checkBC" onclick='consulta3()'; />
		Exames Laboratoriais <td><input type="text" id="examT" size="20" maxlength="35" readonly /></td>
		</td>
		</tr>			
	</table><br>
 </fieldset> </form>
 
<!--https://pt.stackoverflow.com/q/258381/101 
