<p>@Html.DisplayFor(r => r.StreamUrl) </p>

var RadioAtivo = db.Radios
    .Where(p => p.Ativo && !p.Mp3)
    .Take(1);
return View(RadioAtivo.ToList()[0]);

var RadioAtivo = db.Radios
    .Where(p => p.Ativo && !p.Mp3)
    .First();
return View(RadioAtivo.ToList());

@model RadioFM.Domain.Domain.Radio

//https://pt.stackoverflow.com/q/79911/101
