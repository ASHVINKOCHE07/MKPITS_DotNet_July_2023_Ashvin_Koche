#include<stdio.h>
void main()
{
	int n1,n2,*p1=&n1,*p2=&n2,sum=0;
	printf("\nenter two numbers");
	scanf("&d&d",&n1,&n2);
	sum=*p1+*p2;
    printf("\nSum=%d",sum);
}