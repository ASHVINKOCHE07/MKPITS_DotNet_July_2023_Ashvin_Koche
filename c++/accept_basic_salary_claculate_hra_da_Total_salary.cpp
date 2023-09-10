#include<iostream>
using namespace std;
int main() {
	float basic,hra,da,total_salary;
	cout<<"\nEnter basic="<<endl;
	cin>>basic;
	hra=basic * 0.35;
	da=basic * 0.45;
	total_salary=basic + hra + da;
	cout<<"HRA = "<<hra<<endl;
	cout<<"DA = "<<da<<endl;
	cout<<"Total salary = "<<total_salary;
}
