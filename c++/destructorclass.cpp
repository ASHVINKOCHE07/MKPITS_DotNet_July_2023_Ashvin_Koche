#include<iostream>
using namespace std;
class Employee
{
	public:
	Employee()
	{
		cout<<"contructor started"<<endl;
	}
	~Employee()
	{
		cout<<"Distructor started"<<endl;
	}
};
int main()
{
	Employee emp1;
	Employee emp2;
	return 0;
}