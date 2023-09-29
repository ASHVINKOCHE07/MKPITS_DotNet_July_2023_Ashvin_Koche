#include<stdio.h>
#include<string.h>
struct EmployBook
{
	char employ1[50],employ2[50];
	int salary1,salary2;
};
void main()
{
	struct EmployBook b1;
	strcpy(b1.employ1,"Akash");
	strcpy(b1.employ2,"Ashvin");
	b1.salary1=15000;
	b1.salary2=20000;
	printf("\nemploy1=%s",b1.employ1);
	printf("\nemploy2=%s",b1.employ2);
	printf("\nSalary1=%d",b1.salary1);
	printf("\nSalary1=%d",b1.salary2);
	
}