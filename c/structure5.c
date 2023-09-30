#include<stdio.h>
#include<string.h>
struct cust
{
	int balance,bankaco;
	char nameofcustomer[20];
};
void main()
{
	struct cust c[3];
	int counter;
	for(counter=0;counter<3;counter++)
	{
		printf("\nenter account number,name,balance");
		scanf("%d",&c[counter].bankaco);
		scanf("%s",&c[counter].nameofcustomer);
		scanf("%d",&c[counter].balance);
	}
	printf("\nCustomer Details=");
	for(counter=0;counter<3;counter++)
	{
	    printf("\nname=%s",c[counter].nameofcustomer);
		printf("\nAccount Number=%d",c[counter].bankaco);
		if(c[counter].balance<100)
		{
		printf("\nbalance is less than 100=%d",c[counter].balance);
	    }
	    else
	    {
	    printf("\nbalance of customer is equal to or greater than100=%d",c[counter].balance);
		}
	}
}