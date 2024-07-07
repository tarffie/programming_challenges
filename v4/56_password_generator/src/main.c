#include <stdio.h>  
#include <time.h> 
#include <stdlib.h> 

char* generate_string(int size)  //  { int } 
{
    srand(time (NULL));  
    const char ALLOWED[] = "#@!$%^&*()_-+=ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890"; 
    char random[size]; 
    char *ret = malloc(size); 
    if(!ret) return NULL; 
    int c = 0;
    int nbAllowed = sizeof(ALLOWED)-1;
    for(int i = 0; i < size; ++i) { 
        c = rand() % nbAllowed;
        random[i] = ALLOWED[c];
    }
    for(int i = 0; i < size; ++i)
    {
        ret[i] = random[i]; 
    }
    return ret;  
}

int main (int argc, char* argv[])
{
    int count = 0; 
    system("clear"); 
    printf("hello, user. Type a length for your password..\n");
    scanf("%i", &count); 
    char* password = generate_string(count);   
    for(int i = 0; i < count; ++i)
    {
        printf("%c", password[i]);
    }
    printf("\n");
    return 0; 
}
