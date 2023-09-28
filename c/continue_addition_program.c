#include<stdio.h>
void addition(int a,int b)
{
 int result=a+b;
 printf("\n%d + %d=%d",a,b,result);	
}
void main()
{
    char ch='y';
	do
	{
    int a,b;
	printf("\nenter two numbers");
	scanf("%d%d",&a,&b);
	addition(a,b);
	printf("\ndo you want to continue,press Y");
	fflush(stdin);
	scanf("%c",&ch);
}while(ch=='y');
}
