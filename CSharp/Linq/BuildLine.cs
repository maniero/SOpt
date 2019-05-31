var dados = new StringBuilder();
int contador = (from q in lista select q.Codigo).Count(); //queria eliminar isto, não parece fazer sentido
for (int i = quantidade * 10; i < (quantidade * 10) + 10 && i < contador; i++) dados.AppendLine((lista.Single(c => c.Codigo == i.ToString())).Codigo);

//https://pt.stackoverflow.com/q/386185/101
