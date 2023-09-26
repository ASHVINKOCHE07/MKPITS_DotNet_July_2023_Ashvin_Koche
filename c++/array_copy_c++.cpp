#include<iostream>
using namespace std;
int main()
{
	int i,arr1[5],arr2[5];
	for(i=0;i<5;i++)
	{
		cout<<"\nenter numbers of first array";
		cin>>arr1[i];
	}
	for(i=0;i<5;i++)
	{
		arr2[i]=arr1[i];
	}
	cout<<"\nelemnets of array 1";
	for(i=0;i<5;i++)
	{
		cout<<endl<<arr1[i];
	}
	cout<<"\nelement of array 2";
	for(i=0;i<5;i++)
	{
		cout<<endl<<arr2[i];
	}
}