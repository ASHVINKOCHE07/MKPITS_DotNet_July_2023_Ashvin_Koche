#include<iostream>
using namespace std;
class Account
{
	int actno;
	int bal;
	int in;
	void getdata(int a,int r,int b)
	{
		actno=a;
		in=r;
		bal=b;
	}
	
};
class Saving : public Account{
	public:
		int bal;
  int savingac(int amt,int in)
  {
    bal=amt+in;
    return bal;
	}
  };
class Current : public Account
{
	 public:
	 	int bal;
	int currentac(int amt)
	{
		bal=bal+amt;
	return bal;
	}
};
int main()
{
	int ac,b,d,inr,result;
	Saving s;
	Current c;
	cout<<"Enter account no,balance,interest,deposit of saving account "<<endl;
	cin>>ac>>b>>inr>>d;
	s.getdata(b,inr,d);
	result=s.savingac();
	cout<<"account  number of saving account= "<<ac<<endl;
	cout<<"Balance of saving account= "<<result<<endl;
	cout<<"Enter account no,balance,deposit of current account "<<endl;
	cin>>ac>>b>>d;
	c.getdata(b,d);
	result=c.currentac();
	cout<<"account number of current account= "<<ac<<endl;
	cout<<"Balance of cureent account= "<<result;
	return 0;
}
