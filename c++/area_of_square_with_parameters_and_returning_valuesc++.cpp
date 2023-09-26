#include<iostream>
using namespace std;
int area(int num)
{
	int result=num*num;
	return result;

}
int main()
{
	int num,result=0;
	cout<<"Enter num :";
	cin>>num;
	result=area(num);
	cout<<"Area is ="<<result;
	return 0;
}