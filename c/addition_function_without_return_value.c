#include<stdio.h>
int add()
{
	int result,a,b;
	printf("\nenter two numbers");
	scanf("%d%d",&a,&b);
	result=a+b;
	return result;
}
int main()
{
	char c='y';
	
	do{
		int result;
		result=add();
		printf("\nresult=%d",result);
		printf("\ndo you want to continue press y");
		scanf("%c",&c);
	}while(c=='y');
}