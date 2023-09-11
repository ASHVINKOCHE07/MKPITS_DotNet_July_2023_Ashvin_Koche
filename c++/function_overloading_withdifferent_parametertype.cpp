#include<iostream>
using namespace std;
class Calculation{
	public:
		int add(int n1,int n2){
			return(n1+n2);
		}
		float add(float n1,float n2,float n3){
			return(n1+n2+n3);
		}
};
int main()
{
	Calculation c;
	cout<<"sum of (int) two nos= "<<c.add(2,3)<<endl;
	cout<<"sum of (float) three nos= "<<c.add(2.5f,3.5f,5.5f)<<endl;
	return 0;
}
