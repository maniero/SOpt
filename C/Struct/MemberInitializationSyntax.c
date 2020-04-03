struct sockaddr_in saddr = {
    saddr.sin_family      = AF_INET,
    saddr.sin_addr.s_addr = htonl(INADDR_ANY),
    saddr.sin_port        = htons(5000)
};

struct sockaddr_in saddr;
saddr.sin_family = AF_INET;
saddr.sin_addr.s_addr = htonl(INADDR_ANY);
saddr.sin_port = htons(5000);

//https://pt.stackoverflow.com/q/444049/101
