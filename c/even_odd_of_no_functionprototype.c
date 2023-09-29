#include<stdio.h>
int evenodd();
int main()
{
	int a;
	printf("\nenter a numbers");
    scanf("%d",&a);
    evenodd(a);
}
int evenodd(int a)
{

		if(a%2==0)
		{
			printf("\n%d is a even number",a);
		}
		else
		{
			printf("\n%d is a odd number",a);
		}
}
