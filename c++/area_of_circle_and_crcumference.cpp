#include<iostream>
using namespace std;
class Circle
{
 public:
 	int radius;
 	float calcualteArea()
 	{
 		float a=3.14f*radius*radius;
 		return a;
	 }
	float calculatecircm()
	{
		float circ=2*3.14f*radius;
		return circ;
	} 
};
int main()
{
	float result;
	Circle c1;
	cout<<"Enter Radius";
	cin>>c1.radius;
	result=c1.calcualteArea();
	cout<<"area="<<result<<endl;
	result=c1.calculatecircm();
	cout<<"circumfernce="<<result;
	return 0;
}
