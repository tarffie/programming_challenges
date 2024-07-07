#include <iostream> 
#include <cstdlib> 

char* generate_string(int size)  //  { int } 
{
    srand(time (NULL));  
    const char ALLOWED[] = "#@!$%^&*()_-+=ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890"; 
    char random[size]; 
    char *ret; 
    int c = 0;
    int nbAllowed = sizeof(ALLOWED)-1;
    for(int i = 0; i < size; ++i)
    { 
        c = rand() % nbAllowed;
        random[i] = ALLOWED[c];
    }
    for(int i = 0; i < size; ++i)
    {
        ret[i] = random[i]; 
    }
    return ret;  
}

int main(int argc, char* argv[]) 
{ 
    int count = 0; 
    system("clear"); 
    std::cout << ("hello, user. Type a length for your password..") << std::endl;
    std::cin >> (count); 
    char* password = generate_string(count);   
    for(int i = 0; i < count; ++i)
    {
        std::cout << (password[i]);
    }
    std::cout << std::endl;
    return 0; 
}
