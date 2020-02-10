var hoje = new Date(new Date().toDateString());
var data = new Date(new Date(2020, 1, 7).toDateString());
var nDias = Math.ceil((data - hoje) / (1000 * 3600 * 24));
if (nDias > 7) console.log('<span class="label">Faltam ' + nDias + ' dias</span>');
else if (nDias > 2) console.log('<span class="label label-warning">Está proximo</span>');
else if (nDias > 0) console.log('<span class="label label-sm label-yellow">Amanhã</span>');
else if (nDias == 0) console.log('<span class="label label-info">Hoje</span>');
else console.log('<span class="label label-info">Vencido</span>');

//https://pt.stackoverflow.com/q/434855/101
