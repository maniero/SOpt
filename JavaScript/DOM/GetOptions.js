let x = document.getElementById("exemplo");
let txt = "";
for (let i = 0; i < x.options.length; i++) txt += x.options[i].text + "<br>";
console.log(txt);
<form>
  <select id="exemplo" size="4">
    <option>Facebook</option>
    <option>Twitter</option>
    <option>Linkedin</option>
    <option>Instagram</option>
  </select>
</form>

//https://pt.stackoverflow.com/q/432612/101
