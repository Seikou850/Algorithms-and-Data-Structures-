//
//  main.cpp
//  Assessed Exercise 5
//
//  Created by Seikou Bah Karagera on 11/12/2022.
//
#include <iostream>


void substitute(char* s, char c1, char c2)
{
    for (char *i = s; *i != '0'; i++) // This iterate over the characters in the string using pointer arithmetic
    {
        if (*i == c1) // if pointer *i is 'l' and c1 is 'a', replace it with c2 which is equal to 'x'
        {
            *i = c2; 
        }
    }
}

int main(int argc, const char * argv[]) {
    
    
    char s[] = "labelabellabel";
    char c1 = 'a';
    char c2 = 'x';
    
    substitute(s, c1, c2);
    
    std::cout << s << std::endl; // Output: lxbelxbellxbel
}

 
