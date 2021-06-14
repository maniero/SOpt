for (int i = 0; i < 640; i++)
    for (int j = 0; j < 480; j++)
        for (int k = 0; k < 4; k++) {
            ...
            if (condition) {
                ...
                goto fim;
            }
        }
    }
}
:fim

//https://pt.stackoverflow.com/q/147011/101
