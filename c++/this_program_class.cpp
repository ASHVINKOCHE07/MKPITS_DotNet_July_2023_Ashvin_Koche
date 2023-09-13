#include<iostream>
using namespace std;
class Employee
{
	public:
	int empno;
	string empname;
	Employee(int empno,string empname)
	{
		this->empno=empno;
		this->empname=empname;
	}
void display()
	{
		cout<<"Employee Number="<<empno<<endl;
		cout<<"Employee Name="<<empname<<endl;
	}
};
int main()
{
	int empno;
	string empname;
	Employee emp1(123,"RAJNI");
	emp1.display();
	return 0;
}