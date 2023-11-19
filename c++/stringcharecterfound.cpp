#include<iostream>
#include<iostream>
#include<string.h>
#include <cstring>
using namespace std;
int main ()
{
    char str[50], ch;
    int i, pos = 0;
    cout << "Enter a string  : ";
    gets(str);
    cout << "Enter a character : ";
    cin >> ch;
    for (i = 0 ; str[i] != '\0'; i++)
        if (str[i] == ch)
                pos = i;
    if (pos)
        cout << ch << " found at position : " << pos + 1;
    else
    {
        cout << ch << " not found.";
        return NULL;
    }			
    return 0;
}