#include<iostream>
#include<string.h>
using namespace std;
int main ()
{
    char str1[50], str2[50];
    int i, j, pos;
    cout << "Enter string 1 : ";
    gets(str1);
    cout << "Enter string 2 : ";
    gets(str2);
    cout << "Result : ";
    for (i = 0 ; str1[i] != '\0'; i++)
    {
        for (j = 0; str2[j] != '\0'; j++)
        {
            if (str1[i] == str2[j])
            {
                pos = j;
                break;
            }    
        }
    }   
    if (pos == 0)
    {
        cout << "NULL";
        return NULL;
    }
    while (str1[pos] != '\0')
    {
        cout << str1[pos];
        pos++;
    }
    return 0;
}