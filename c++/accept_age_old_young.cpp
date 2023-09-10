#include<iostream>
using namespace std;
int main() {
	int age;
	cout<<"Enter age ="<<endl;
	cin>>age;
	if(age>60) {
		cout<<age<<"is old";
	} else {
		cout<<age<<"is young";
	}
	return 0;
}
