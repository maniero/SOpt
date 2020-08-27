IQueryable<Produtos> query = _context.Produtos;
query = query.Where(x => x.Nome == pesquisa.Nome);
query = query.Where(x => x.Material == pesquisa.Material);
query = query.Where(x => x.Estado == pesquisa.Estado);
query = query.Where(x => x.Preco >= pesquisa.PrecoInicial && x.Preco <= pesquisa.PrecoFinal);
resultado = query.ToListAsync();

IQueryable<Produtos> query = _context.Produtos;
if (pesquisa.Nome != null) query = query.Where(x => x.Nome == pesquisa.Nome);
if (pesquisa.Material != null) query = query.Where(x => x.Material == pesquisa.Material);
... //aqui coloca tudo o que deseja
resultado = await query.ToListAsync();

//https://pt.stackoverflow.com/q/361557/101
