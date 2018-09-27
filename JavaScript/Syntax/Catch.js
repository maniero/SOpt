var letters = new Array("A","B","C","D","E")
function getLetter(fld) {
    try {
        var inp = parseInt(fld.value, 10)
        if (isNaN(inp)) throw "Entry was not a number."
        if (inp < 0 || inp > 4) throw "Enter only 0 through 4."
        fld.form.output.value = letters[inp]
     } catch (e) {
        console.log("deu erro");
     }
}

<FORM>
Enter a number from 0 to 4: 
<INPUT TYPE="text" NAME="input" SIZE=5>
<INPUT TYPE="button" VALUE="Get Letter" onClick=getLetter(this.form.input)>
Matching Letter is:<INPUT TYPE="text" NAME="output" SIZE=5>
</FORM>

//https://pt.stackoverflow.com/q/331977/101
