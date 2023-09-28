#include<stdio.h>
int t(int num)
{
	int result=0;
	int counter;
	for(counter=1;counter<=10;counter++)
	{
		result=num*counter;
		printf("\n%d * %d=%d",num,counter,result);
	}
}
int main()
{
	int a;
	printf("\nenter no to print table=");
	scanf("%d",&a);
	t(a);
}
	

