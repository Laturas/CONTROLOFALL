#include <stdio.h>

int main(int argc, char* argv[]) {
    unsigned long long bruh = 8698805455709;
    unsigned long long bruh2 = 8549371;
    unsigned long long bruh3 = 1017479;
    bruh *= bruh2 * 2;
    bruh2 = bruh;
    int i = 0;
    while (bruh != 0x666C6573794D676E) {
        bruh *= 1017479;
        i++;
        printf("%llu\n",bruh); fflush(stdout);
        return 1;
    }
    printf("%d\n",i);
}