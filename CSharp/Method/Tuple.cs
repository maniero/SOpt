void M(int p1 = 1, string p2 = "", bool p3 = true, int p4 = 0) { ... }

M(2); //na prática chama M(2, "", true, 0)

void M(p1: 1, p4: 0, p3: true)

void M(Tuple<int, string, bool, int> p) { ... }

M(new Tuple<int, string, bool, int>(3, "teste", false, 1));

M(new Tuple(3, "teste", false, 1));

void M(params IEnumerable<int> p) { foreach(int i in p) Console.WriteLine(i); }

void M((int valor, string nome, bool status, int outro) p) { ... }

M((3, "teste", false, 1));

//https://pt.stackoverflow.com/q/14532/101
