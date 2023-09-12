#include<iostream>
using namespace std;
class Employ {
	public:
		string name;
		string Designation;
		string address;

};
class Details :public Employ {
	public:
		int salary;
		int empno;
};
int main() {
	Details e1;
	cout<<"Enter name,Designation,address,salary ,empno =";
	cin>>e1.name>>e1.Designation>>e1.address>>e1.salary>>e1.empno;
	cout<<e1.name<<endl<<e1.Designation<<e1.address<<endl<<e1.salary<<endl<<e1.empno;
	return 0;
}
