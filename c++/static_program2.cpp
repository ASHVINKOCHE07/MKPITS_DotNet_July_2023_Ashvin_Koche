#include<iostream>
using namespace std;
class Employee {
	public:
		string empname;
		int empno;
		static string companyname;
		Employee(string empname,int empno){
			this->empname=empname;
			this->empno=empno;
		}
		void display() {
			cout<<"employee name >"<<empname<<endl;
			cout<<"employee no >"<<empno<<endl;
			cout<<"company name >"<<companyname<<endl;
		}
};
string Employee::companyname="Amazon";
int main() {
	Employee e1=Employee("ravi",123);
	Employee e2=Employee`("suresh",456);
	e1.display();
	e2.display();
	return 0;
}
