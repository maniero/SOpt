StringBad & StringBad::operator=(const StringBad & st) {
    if (this == &st)    // object assigned to itself
    return *this;   // all done
    delete [] str;  // free old string
    len = st.len;
    str = new char [len + 1];   // get space for new string
    std::strcpy(str, st.str);   // copy the string
    return *this;   // return reference to invoking object
}

in main() {
    StringBad headline1("Celery Stalks at Midnight");
    StringBad knot = headline1;
    cout << "knot: " << knot << endl;
    cout << "knot: " << knot = headline1 << endl;
}

//https://pt.stackoverflow.com/q/222048/101
