#include <stdio.h>
#include <string.h>

char tracks[][80] = {
    "I left my heart in Harvard Med School",
    "Newark, Newark - a wonderful town",
    "Dancing with a Dork",
    "The girl from Iwo Jima",
};

void find_track(char search_for[]) {
	search_for[strcspn(search_for, "\n")] = 0;
    for (int i = 0; i < 5; i++) if (strstr(tracks[i], search_for)) printf("Track %i: '%s'\n", i, tracks[i]);
}

int main() {
    char search_for[80];
    printf("Search for: ");
    fgets(search_for, 80, stdin);
    find_track(search_for);
}

//https://pt.stackoverflow.com/q/106706/101
