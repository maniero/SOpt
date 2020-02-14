for (var i = 1; i < 6; i++) { 
    $('#page0' + i).removeClass('btn-warning').addClass(i == 1 ? 'btn-success' : 'btn-warning');
    document.getElementById('analysisFullGraphContainer' + i).style.display = i == 1 ? 'block' : 'none';
    document.getElementById('copyGraph0' + i).style.display = i == 1 ? 'block' : 'none';
}

//https://pt.stackoverflow.com/q/146194/101
