#include<iostream>
using namespace std;
int main()
{
	int num;
	int sn=1;
	int tablevalue;
	int counter=1;
	cout<<"\nenter number to print it's table";
	cin>>num;
	while(counter<=10)
	{
		tablevalue=num*counter;
		cout<<endl<<tablevalue;
		counter=counter+1;
		sn=sn+1;
	}
}
