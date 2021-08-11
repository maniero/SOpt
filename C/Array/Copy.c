memcpy(e1, e2, sizeof(events) * 100);

copy(begin(e1), end(e1), begin(e2));

for (auto i = 0; i < 100; i++)  e2[i] = e1[i];

//https://pt.stackoverflow.com/q/322684/101
