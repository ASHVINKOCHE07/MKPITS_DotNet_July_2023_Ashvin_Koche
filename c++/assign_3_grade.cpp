#include<iostream>
using namespace std;
class grade
{
	public:
	int classno,rollno,marks;
	string name;
	void grading()
	{
		if(marks>75)
		{
			cout<<"Grade=A";
		}
		if(marks<=75&&marks>60)
		{
			cout<<"Grade=B";
		}
		if(marks<=60&&marks>50)
		{
			cout<<"Grade=C";
		}
		if(marks<=50&&marks>=40)
		{
			cout<<"Grade=D";
		}
	    if(marks<40)
	    {
	    	cout<<"Grade=F";
		}
	}
};
int main()
{
	class grade g1;
	cout<<"enter name,class num,roll no,marks";
	cin>>g1.name>>g1.classno>>g1.rollno>>g1.marks;
	cout<<"Student Details>>>"<<endl;
	cout<<g1.name<<endl;
	cout<<g1.classno<<endl;
	cout<<g1.rollno<<endl;
	cout<<g1.marks<<endl;
	g1.grading();
	return 0;
}