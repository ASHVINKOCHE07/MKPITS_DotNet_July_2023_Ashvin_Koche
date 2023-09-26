#include<iostream>
using namespace std;
class Rollno {
	private:
		int rno;
	public:
		void display() {
			cout<<"ROLL NO  ="<<rno;
		}
		void setdata(int r) {
			rno=r;
		}
};
int main() {
	Rollno r1;
	int r;
	cout<<"ENTER ROLL NO";
	cin>>r;
	r1.setdata(r);
	r1.display();
    return 0;
}
