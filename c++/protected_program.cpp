#include<iostream>
using namespace std;
class Person {
	protected:
		string name;

};
class Student : private Person {
	public:
		void setdata(string n) {
			name=n;
		}
		void display() {
			cout<<"Student Name ="<<name;
		}
};
int main() {
	Student s1;
	s1.setdata("ASHVIN");
	s1.display();
	return 0;
}
