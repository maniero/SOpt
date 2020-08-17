function bhaskaraP(ab, bb, cb) {
	var Mb = bb * -1;
	var b2 = bb * bb;
	var delta0 = b2 - 4 * ab * cb;
	var delta = Math.sqrt(delta0);
	var rstM = (-bb + Math.sqrt(delta0)) / 2 * ab;
  return rstM;
}

function bhaskaraN(ac, bc, cc) {
	var Mbc = bc * -1;
	var b2c = bc * bc;
	var delta0c = b2c - 4 * ac * cc;
	var deltac = Math.sqrt(delta0c);
	var rstN = (Mbc - deltac) / 2 * ac;
	return rstN;
}
form.addEventListener('submit', function () {
  var form = document.getElementById("form");
  var a = document.getElementById("a");
  var b = document.getElementById("b");
  var c = document.getElementById("c");
  var ax = a.value;
  var bx = b.value;
  var cx = c.value;
  var bh1 = bhaskaraP(ax, bx, cx);
  var bh2 = bhaskaraN(ax, bx, cx);
	alert(bh1 + " " + bh2);
})
<div>
   <form id="form">
      Digite o A:&emsp;<input id="a" type="number">
      <br>
      <br>
      Digite o B:&emsp;<input id="b" type="number">
      <br>
      <br>
      Digite o C:&emsp;<input id="c" type="number">
      <br>
      <input type="submit">
   </form>
</div>

//https://pt.stackoverflow.com/q/344504/101
