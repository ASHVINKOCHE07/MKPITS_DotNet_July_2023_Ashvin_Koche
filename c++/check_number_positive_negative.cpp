#include<iostream>
using namespace std;
int main() {
	int num;
	cout<<"Enter number";
	cin>>num;
	if(num<0) {
		cout<<"Number is negative";
	} else if(num == 0) {
		cout<<"Number is Zero";
	} else {
		cout<<"Number is Positive";
	}
}
