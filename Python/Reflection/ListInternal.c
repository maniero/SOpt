case BINARY_SUBSCR:
    w = POP();
    v = TOP();
    if (PyList_CheckExact(v) && PyInt_CheckExact(w)) {
        /* INLINE: list[int] */
        Py_ssize_t i = PyInt_AsSsize_t(w);
        if (i < 0)
            i += PyList_GET_SIZE(v);
        if (i >= 0 && i < PyList_GET_SIZE(v)) {
            x = PyList_GET_ITEM(v, i);
            Py_INCREF(x);
        }
        
//https://pt.stackoverflow.com/q/165773/101
