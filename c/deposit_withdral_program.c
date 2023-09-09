#include<stdio.h>
void deposit();
void withdrawl();
void main()
{
 int amt=0,bal=1000;
 printf("\nEnter amount=");
 scanf("%d",&amt);
 deposit(amt,bal);
 withdrawl(amt,bal);
}
void deposit(int amt,int bal)
{
 bal=bal+amt;
 printf("\nAmount deposited=%d",bal);	
}
void withdrawl(int amt,int bal)
{
	bal=amt-bal;
	printf("\nAmount withdrawl balance is %d",bal);
}