struct Item { public string AdminId, public string GroupId }
var lista = new List<Item>() { new Item { var1, var2 }, };

var lista = new List<(string AdminId, string GroupId)>() { (var1, var2), };

foreach (var item in fonteDeDados) lista.Add((item.AdminId, item.GroupId));

foreach (var item in fonteDeDados) lista.Add(new Item() { item.AdminId, item.GroupId });

//https://pt.stackoverflow.com/q/321957/101
