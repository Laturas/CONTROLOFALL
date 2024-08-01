#include <stdio.h>
#include "image_array"

//int af[5] = [50 72 6F 76 69 64 65 20 61 20 6B 65 79];
int af[4] = {0x76600250, 0x20600469, 0x65600061, 0x00000A79};

char* z = "*********************************************************************";
char* a = "The people who changed our lives the most may never even know";
char* b = "Something as simple as an invitation to a local for-fun competition";
char* c = "I took a chance, a small one, and it changed my life forever";
char* d = "I wonder if he recognizes that impact";
char* y = "********************************************************************";

void swap(char* one, char* two, int index) {
    char temp = (one)[index];
    (one)[index] = (two)[index];
    (two)[index] = temp;
}

int main(int argc, char* argv[]) {
    
    //printf("key: %s\nfke: %s\n",key,fke);
    af[0] |= 0xF7000;
    af[1] |= 0x56000;
    af[2] |= 0xB2000;
    char* to_print = "Memories are what make us who we are\n";
    printf(to_print); fflush(stdout);
    char buf[255] = {0};
    int i = 0;
    while (1) {
        scanf("%c", &buf[i]);
        if (buf[i] == '\n') {break;}
        if (i++ == 34) {printf("And thus?\n"); return 1;}
    }
    //char* past = "Our present is shaped by our past";
    char* enc = "Tzw%uwjxjsy%nx%xmfuji%g~%tzw%ufxy";
    for (int i = 0; i < 33; i++) {
        if (buf[i] != (char)(enc[i] - 5)) {printf("And thus?\n"); return 1;}
        //printf("%c", (char)(past[i] + 5));
    }
    printf("The things we bring along the way can act as capsules, vaults of memories\n"); fflush(stdout);

    char key[] = "betmby eie  enro purlt  nhomoirtf rhs we are";
    char fke[] = "Wi  ay bvtnwi'cerboiateitte  un oowmo";
    char save2 = buf[7];

    for (int i = 0; i < 38; i += 2) {
        swap(key,fke,i);
    }
    i = 0;
    while (1) {
        scanf("%c", &buf[i]);
        if (buf[i] == '\n') {break;}
        if (i++ == 44) {printf("So recognize them for what they are\n"); return 1;}
    }
    char save = buf[10];
    for (int i = 0; i < 44; i++) {
        if (buf[i] != key[i]) {printf("So recognize them for what they are\n"); return 1;}
        //printf("%c", (char)(past[i] + 5));
    }
    printf("They are, however, not you. And sometimes it is best if we can let some things go\n"); fflush(stdout);

    char lastkey[91] = "I pondered for a while. But what could we possibly afford to lose? I awaited for an answer";
    
    i = 0;
    while (1) {
        scanf("%c", &buf[i]);
        if (buf[i] == '\n') {break;}
        if (i++ == 43) {printf("Reflect\n"); return 1;}
    }
    buf[44] = '\0';
    for (int i = 24; i < 66; i++) {
        if (buf[i - 24] != lastkey[i]) {printf("I did not know\n"); /*printf("input: %s\nkey: %s\n",buf,lastkey); printf("diff at: %d\ninput:%c\nkey:%c\n",i,buf[i - 25],lastkey[i]);*/ return 1;}
        //printf("%c", (char)(past[i] + 5));
    }
    for (int i = 0; i < 50; i++) {
        if (i == 20) {continue;}
        char s[20] = {0};
        sprintf(s, "memory_%d", i);
        FILE* let_go = fopen(s,"r");
        if (let_go) {printf("But yet, I never let go\n"); return 1;}
    }
    char* warning = "Just letting you know now, it'll be easier to just solve the puzzle than to try and de-obfuscate this";
    char final[13] = {(char)(a[27]-32),key[18],lastkey[63],buf[22],save,(char)(enc[16]-6),to_print[0],buf[25],save2,(char)(save2-14),(char)108,buf[28],'\0'};
    printf("...there was no response, the answer would not have mattered.\nFor I felt losing anything would be %s\n",final);

    FILE* theend = fopen("DiggingDeeper.bmp","r");
    if (theend) {
        FILE* endofall = fopen("DiggingDeeper.bmp","w"); 
        for (int i = 0; i < 360054; i++) {
            fprintf(endofall, "%c", image_bytes[i]);
        }
    }
}