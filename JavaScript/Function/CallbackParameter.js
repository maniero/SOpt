function (obj, callback) {
    var length, i = 0;
    if (isArrayLike(obj)) {
        length = obj.length;
        for (; i < length; i++) if (callback.call(obj[i], i, obj[i]) === false) break;
    } else for (i in obj) if (callback.call(obj[i], i, obj[i]) === false) break;
    return obj;
}

//https://pt.stackoverflow.com/q/88986/101
