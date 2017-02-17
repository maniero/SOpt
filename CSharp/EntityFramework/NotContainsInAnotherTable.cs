db.Producao.Where(p => !db.Bpi.Select(b => b.idProducao).Contains(c.CusId));

//http://pt.stackoverflow.com/q/184843/101
