#include<stdio.h>
int main()
{
	int num1,num2,*ptr1,*ptr2,sum=0;
	printf("\nEnter two numbers");
	scanf("%d%d",&num1,&num2);
	ptr1=&num1;
	ptr2=&num2;
	sum= *ptr1 + *ptr2;
	printf("\nsum=%d",sum);
	
}