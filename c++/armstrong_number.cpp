#include<iostream>
using namespace std;
int main()
{
    int num;
	int r;
	int sum=0;
	int p;

    cout<<"Input  a number: ";
    cin>>num;
    for(p=num;num!=0;num=num/10)
	{
         r=num % 10;
         sum=sum+(r*r*r);
    }
    if(sum==p)
        {
	  cout<<p<<"is an Armstrong number";
	    }
    else
	{
	
         cout<<p<<"is not an Armstrong number";
    }
	return 0; 
}

