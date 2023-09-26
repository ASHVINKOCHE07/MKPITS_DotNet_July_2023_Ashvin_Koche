#include<iostream>
using namespace std;
class Employee
{
	public:
      int employno;
      string employname;
      Employee()
      {
    	employno=123;
    	employname="GOPAL";
	  }
	  void display()
	  {
	  	cout<<"Employ Number}}}"<<employno<<endl;
	  	cout<<"Employ Name}}}"<<employname<<endl;
	  	
		}  
};
int main()
{
    Employee emp1;
	cout<<"Employ details\\\\"<<endl;
	emp1.display();
	return 0;
}