/*
 * C++ Program to illustrate structs
 */
#include <iostream>
 
struct Car {
    std::string brand;
    int age;
    void setAge(void) {
        std::cout << "Enter the age of car : ";
        std::cin >> age;
    }
    void setBrand(void) {
        std::cout << "\nEnter the name of car : ";   
        std::cin >> brand;
    }
};
 
void howOld(Car cc)
{
    if(cc.age > 5)
        std::cout << std::endl << cc.brand << " is very old.";
    else
        std::cout << std::endl << cc.brand << " is very new.";
}
 
int main()
{
    Car cc;
 
    cc.setAge();
    cc.setBrand();
    howOld(cc);
}