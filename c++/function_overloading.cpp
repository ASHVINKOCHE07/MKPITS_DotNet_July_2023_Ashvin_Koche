#include<iostream>
using namespace std;
class Calculation{
	public:
		int add(int n1,int n2){
			return(n1+n2);
		}
		int add(int n1,int n2,int n3){
			return(n1+n2+n3);
		}
};
int main()
{
	Calculation c;
	cout<<"sum of two nos= "<<c.add(2,3)<<endl;
	cout<<"sum of three nos= "<<c.add(2,3,5)<<endl;
	return 0;
}
