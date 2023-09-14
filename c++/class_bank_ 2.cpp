#include<iostream>
using namespace std;
class Customer
{
	public:
	int accountnumber,balance=0,deposit,withdrawl;
	int Deposit()
	{
		balance=balance+deposit;
		return balance;
	}
	int Withdrawl()
	{
		balance=balance-withdrawl;
		return balance;
	}
	
};
int main()
{
	class Customer c1;
	int output;
	cout<<"Enter Account Number and deposit and withdrawl"<<endl;
	cin>>c1.accountnumber>>c1.deposit>>c1.withdrawl; 
	output=c1.Deposit();
	cout<<"Balance after Deposit="<<output<<endl;
	output=c1.Withdrawl();
	cout<<"balance after withdrawl="<<output;
}