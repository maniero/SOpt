<html>
<head>
  <title>HTML vs Text</title>
  <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
  <script type="text/javascript">
    $(function(){
      $("#div1").html('<a href="example.html">Link</a><b>hello</b>');
      $("#div2").text('<a href="example.html">Link</a><b>hello</b>');
    });
  </script>
</head>
<body>
  <div id="div1"></div>
  <div id="div2"></div>
</body>
</html>

//https://pt.stackoverflow.com/q/17792/101
