var obj = new Classe();
// ...
obj2.Event += obj.objEventHandler;
// ...
obj = null //deveria librar para o GC coletar, mas ainda tem referência p/ ele

obj2.Event -= obj.objEventHandler;

//https://pt.stackoverflow.com/q/186644/101
