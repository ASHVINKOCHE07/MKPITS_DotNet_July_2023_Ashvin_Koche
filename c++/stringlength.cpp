#include<iostream>
#include<iostream>
#include<string.h>
using namespace std;
int main ()
{
    char str1[50], str2[50];
    int i, j, count = 0;
    cout << "Enter string 1 : ";
    gets(str1);
    cout << "Enter string 2 : ";
    gets(str2);
    for (i = 0 ; str1[i] != '\0'; i++)
    {
        for (j = 0; str2[j] != '\0'; j++)
        {
            if (str1[i] == str2[j])
                count++;
        }
    }   
    cout << "Length of string 1 containing '" << str2 << "' characters : " << count;
    return 0;
}