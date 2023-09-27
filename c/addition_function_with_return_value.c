#include<stdio.h>
int addition(int num1,int num2)
{
	int result=num1+num2;
	return result;
}
int main()
{
	char c='y';
	int a,b,result;
	while(c=='y')
	{
	printf("\nenter two numbers");
	scanf("%d%d",&a,&b);
	result=addition(a,b);
	printf("%d",result);
	printf("\nif want continue press y");
	fflush(stdin);
	scanf ("%c",&c);
    }
}