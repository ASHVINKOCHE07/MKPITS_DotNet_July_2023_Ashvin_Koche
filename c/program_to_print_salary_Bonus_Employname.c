#include<stdio.h>
int main()
{
	char name[10];
	int salary,bonus=0;
	printf("\nEnter name =");
	scanf("%s",&name);
	printf("\nEnter Salary = ");
	scanf("%d",&salary);
	if(salary >= 10000)
	{
		bonus=5000;
	}
	else if(salary >= 5000 && salary<1000)
	{
		bonus=2000;
	}
	printf("\nEmploy name =%s",name);
	printf("\nEmploy salary =%d",salary);
	printf("\nEmploy bonus =%d",bonus);
}
