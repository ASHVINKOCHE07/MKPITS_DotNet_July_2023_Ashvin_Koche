#include<iostream>
using namespace std;
int main()
{
	int m1,m2,m3,total;
	float per;
	cout<<"Enter 3 subject marks =";
	cin>>m1>>m2>>m3;
	total=m1 + m2 + m3;
	per=(total/300.00f) * 100.0f;
	cout<<"Total marks = "<<total<<endl;
	cout<<"Percentage= "<<per<<endl;
	if(per>=75)
	{
		cout<<"Grade=Distinction";
	}
	else if(per>=60 && per<75)
	{
		cout<<"Grade=A";
	}
	else if(per>=50 && per<60)
	{
		cout<<"Grade=B";
	}
	else if(per>=35 && per<35)
	{
		cout<<"Grade=C";
	}
	else
	{
		cout<<"Fail";
	}
}
	
	