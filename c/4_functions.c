#include<stdio.h>
void m(int a,int b)
{
 int result=a*b;
 printf("\n%d x %d=%d",a,b,result);	
}
void main()
{
    char ch='y';
	do
	{
    int c,d;
	printf("\nenter two numbers");
	scanf("%d%d",&c,&d);
	m(c,d);
	printf("\ndo you want to continue,press Y");
	fflush(stdin);
	scanf("%c",&ch);
}while(ch=='y');
}
