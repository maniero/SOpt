//Veja em exemplo usando um IEnumerable<T>:

var ent = new EntFuncionarios();
IEnumerable<Funcionario> funcionario = ent.Funcionarios; 
IEnumerable<Funcionario> temp = funcionario.Where(x => x.FuncID == 2).ToList<Funcionario>();

//Todos os funcionários virão do banco de dados e depois serão analisados um a um no Where.

//E com IQueryable<T>:

var ent = new EntFuncionarios();
IQueryable<Funcionario> funcionario = ent.Funcionarios; 
IEnumerable<Funcionario> temp = funcionario.Where(x => x.FuncID == 2).ToList<Funcionario>();

//Uma consulta SQL é criada e somente os dados necessários são trazidos para análise desta consulta.

//http://pt.stackoverflow.com/q/17284/101
