#include<iostream>
using namespace std;
class Person {
	public:
		string name;
		int mobno;
};
class Employee : public Person {
	public:
		int empno;
		int salary;

};
class Parttimeemployee : public Employee {
	public:
		int workh;
};

int main() {
	Employee e1;
	e1.name="arti";
	e1.mobno=123;
	e1.empno=223;
	e1.salary=120000;
	cout<<"\n\n****Part time Employee Details****>>"<<endl;
	cout<<e1.name<<endl<<e1.mobno<<endl<<e1.empno<<endl<<e1.salary<<endl;
	Parttimeemployee p1;
	p1.name="Manoj";
	p1.mobno=223;
	p1.empno=456;
	p1.salary=150000;
	p1.workh=9;
	cout<<"\n\n****Part time Employee Details****>>"<<endl;
	cout<<p1.name<<endl<<p1.mobno<<endl<<p1.empno<<endl<<p1.salary<<endl<<p1.workh;
	return 0;
}
