int y = x ?? -1;

int y = (x == null) ? -1 : x;

int?

x.ExecuteAlgo();

x?.ExecuteAlgo();

if (x != null)
    x.ExecuteAlgo();

x?.y?.z;

(x == null ? null : (x.y == null ? null : x.y.z))

//https://pt.stackoverflow.com/q/44133/101
