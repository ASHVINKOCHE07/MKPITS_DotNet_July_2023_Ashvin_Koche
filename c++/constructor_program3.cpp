#include<iostream>
using namespace std;
class Employee
{
	public:
		int empno;
		string empname;
	Employee(int en,string ename)
	{
		empno=en;
		empname=ename;
	}
	void display()
	{
		cout<<"Employ no="<<empno<<endl;
		cout<<"Employ Name="<<empname<<endl;
	}
};
int main()
{
	int en;
	string ename;
	cout<<"Enter Employ number and name";
	cin>>en>>ename;
	Employee emp1(en,ename);
	emp1.display();
	return 0;
}