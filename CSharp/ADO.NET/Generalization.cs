foreach (var item in codigos) if (_strLinesFinal.Contains(item.Key)) _OS = _OS.Replace(item.Key, item.Value);
Para inicializar o dicionário seria algo assim:

var codigos = new Dictionary {
    ["M50"] = "T90",
    ["M60"] = "T91",
    ["S555"] = "C100", };
Se for pegar de um banco de dados ao invés desses códigos de equivalente estiver no código da aplicação, ele será criado lendo o banco de dados. Até pode usar o próprio banco de dados direto e nem criar o dicionário. Teria que mudar alguma coisa, mas funciona. Depende do caso. Provavelmente eu faria o cache no dicionário. Depende da tecnologia de banco de dados que está usando, mas seria algo assim:

var codigos = new Dictionary<string, string>();
using var cmd = new SqlCommand("select codigo, equivalencia from codigos", dbConn));
using var reader = cmd.ExecuteReader());
while (reader.Read()) codigos[(string)reader["codigo"]] = (string)reader["equivalencia"];

//https://pt.stackoverflow.com/q/157938/101
