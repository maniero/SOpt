int main() {
    char const* path = "/bla/bla";
    int *errorp;
    struct zip *teste = zip_open(path, ZIP_CREATE, errorp);
}

//https://pt.stackoverflow.com/q/386436/101
