#include<iostream>
using namespace std;
class ClassA {
	public:
		void display() {
			cout<<"Display from classA"<<endl;
		}
};
class ClassB {
	public:
		void display() {
			cout<<"Display from classB"<<endl;
		}
};
class ClassC:public ClassA,public ClassB {
	public:
		void displayc() {
			cout<<"first number = "<<n1<<endl;
			cout<<"second number = "<<n2<<endl;
			cout<<"Total = "<<n1 + n2<<endl;
		}
};
int main() {
	ClassC c1;
	c1.displayc();
	return 0;
}
