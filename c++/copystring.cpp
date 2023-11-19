#include<iostream>
using namespace std;
int main ()
{
    char str[50], cpy[50];
    int n;
    cout << "Enter a string : ";
    gets(str);
    cout << "Enter number of characters to be copied : ";
    cin >> n;
    strncpy(cpy, str, n);
    cout << "Copied string : " << cpy;
    return 0;
}