<form name="formulario" action="form.php">
    Digite algo: <input type="text" name="campo">
    <a href="javascript: submitform()">Envie</a>
</form>
<script type="text/javascript">
    function submitform() {
        document.formulario.submit();
    }
</script>

$.post( "test.php", { name: "John", time: "2pm" })
  .done(function( data ) {
    alert( "Data Loaded: " + data );
  });
  
//https://pt.stackoverflow.com/q/47653/101
