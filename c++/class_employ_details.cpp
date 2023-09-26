#include<iostream>
using namespace std;
class employs
{
	public:	
	    string name;
		string designation;
		int no,salary;		
void getdata()
{
	cout<<"enter employ no ,name,designation and salary"<<endl;
	cin>>no>>name>>designation>>salary;
}
void displaydata()
{
   	cout<<"employ no "<<no<<endl;
   	cout<<"employ name "<<name<<endl;
   	cout<<"employ desigantion "<<designation<<endl;
   	cout<<"employ salary "<<salary<<endl;

}
};
int main()
{
	employs e1,e2;
	cout<<"employ 1>>"<<endl;
	e1.getdata();
	e1.displaydata();
    cout<<"employ 2>>"<<endl;
	e2.getdata();
    e2.displaydata();    
	return 0;
}