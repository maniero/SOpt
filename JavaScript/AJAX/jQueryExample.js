for (var i = 0; i < 60; i++) {
    console.log("For:" + i);
    (function(p) {
        $.ajax({
            url: "http://servicomapas.ibge.gov.br/api/mapas/" + p + '/1',
            dataType: "json",
            success: function(data) {
                console.log("AJAX:" + p);
            }
        });
    })(i);
}

<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>

//https://pt.stackoverflow.com/q/130740/101
