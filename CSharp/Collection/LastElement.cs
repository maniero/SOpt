var count = list.Length;

foreach(var element in list) {
    if (--count > 0) {
        //is last
    }
}

using (var enumerator = .GetEnumerator()) {
    var last = !enumerator.MoveNext();
    T current;
    while (!last) {
        current = enumerator.Current;
        last = !enumerator.MoveNext();
        if (last) {
            //is last
        }       
    }
}

elements.ForEach((element, info) => {
    if (info.IsLast) {
        //is last
    }
});

//https://pt.stackoverflow.com/q/138009/101
