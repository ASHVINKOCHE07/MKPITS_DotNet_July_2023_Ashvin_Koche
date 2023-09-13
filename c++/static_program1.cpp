#include<iostream>
using namespace std;
class Account {
	public:
		int actno,bal;
		static float roi;
		Account(int actno,int bal) 
			this->actno=actno;
			this->bal=bal;
		}
		void display() {
			cout<<"ACT NO>"<<actno<<endl;
			cout<<"BALANCE>"<<bal<<endl;
			cout<<"RATE OF INTREST>"<<roi<<endl;
		}
};
float Account::roi=9.5f;
int main() {
	Account A1=Account(123,2000);
	Account A2=Account(212,3000);
	A1.display();
	A2.display();
	return 0;
}
