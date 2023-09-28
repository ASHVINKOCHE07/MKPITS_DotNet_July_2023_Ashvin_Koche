#include<stdio.h>
int f(int num)
{
	int fact=1;
	while(num>0)
	{
		fact=fact*num;
		num=num-1;
	}
	printf("\nFactorial = %d",fact);
    return(fact);
}

main()
{
	int a;
	printf("\nenter a number");
	scanf("%d",&a);
	f(a);
}