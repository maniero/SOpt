var result = (from l in db.Schedule_Status
    .Where(x => x.nu_mes == 12)
    .Select(x => new {
        nu_ano = x.nu_ano,
        nu_mes = x.nu_mes,
        id_projeto = x.id_projeto,
        id_fase = x.id_fase,
        ds_categoria = "Financial Progress (\"Competência\")",
        ds_curva = "Baseline"
    })
    select l).ToList();
    
//https://pt.stackoverflow.com/q/292645/101
