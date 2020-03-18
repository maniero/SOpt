#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct Time{
    char name[30];
    int pnts;
    int vit, emp, der;
    int gf, gt;
    struct Time *next;
    struct Time *prev;
} time;

typedef struct campeonato { time *first; } campeonato;

void addTime(campeonato *c, char name[]) {
    time *t = malloc(sizeof(time));
	strcpy(t->name, name);
    t->next = NULL;
    t->pnts = t->vit = t->emp = t->der = t->gt = t->gf = 0;
    if (c->first == NULL) {
    	c->first =  t;
	    t->prev = NULL;
    } else {
	    time *p = c->first;
    	while (p->next != NULL) p = p->next;
	    p->next = t;
    	t->prev = p;
    }
}

int main(void) {
	campeonato c = { .first = NULL };
	addTime(&c, "Santos");
	time *t = c.first;
	printf("%s", t->name);
}

//https://pt.stackoverflow.com/q/162373/101
