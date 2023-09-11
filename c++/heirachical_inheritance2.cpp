
#include<iostream>
using namespace std;
class Shape {
	public:
		int x,y;
		void getdata(int a,int b) {
			x=a;
			y=b;
		}
};
class Rectangle : public Shape {
	public:
		int ra;
		int crecarea() {
			ra=x * y;
			return ra;
		}

};
class Triangle: public Shape {
	public:
		float ta;
		float ctarea() {

			ta=0.5f * x * y;
			return ta;
		}
};
int main() {
	Rectangle r;
	Triangle t;
	int len,bre,bas,hei,ra1;
	float ta1;
	cout<<"Enter length and breadth"<<endl;
	cin>>len>>bre;
	r.getdata(len,bre);
	ra1=r.crecarea();
	cout<<"area of rectangle="<<ra1<<endl;
	cout<<"Enter base and height of triangle"<<endl;
	cin>>bas>>hei;
	t.getdata(bas,hei);
	ta1=t.ctarea();
	cout<<"triangle area= "<<ta1;
	return 0;
}
