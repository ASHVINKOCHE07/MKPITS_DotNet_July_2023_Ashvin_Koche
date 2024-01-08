/*
 * C++ Program to Illustrate Stack Adaptor
 */
 
#include <iostream>
#include <stack>
 
int main()
{
    std::stack< char > s;
 
    // Pushing elements into stack
    for (char c = 'a'; c <= 'f'; c++)
    {
        s.push(c);
    }
    while (!s.empty())
    {
        std::cout << "Top element of stack \'" << s.top()
                  << "\'" << std::endl;
        s.pop();
    }
    std::cout << "Stack is empty!" << std::endl;
}