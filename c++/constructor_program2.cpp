#include<iostream>
using namespace std;
class Employee {
	public:
		int employno;
		string employname;
		Employee(int eno,string en) {
			employno=eno;
			employname=en;
		}
		void display() {
			cout<<"Employ Number}}}"<<employno<<endl;
			cout<<"Employ Name}}}"<<employname<<endl;
		}
};
int main() {
	int eno;
	string en;
	Employee emp1(11,"amit");
	cout<<"Employ details\\\\"<<endl;
	emp1.display();
	return 0;
}