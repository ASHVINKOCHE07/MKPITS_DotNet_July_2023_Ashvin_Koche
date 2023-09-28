#include<stdio.h>
main()
{
	int a;
	printf("\nenter a number");
	scanf("%d",&a);
	p(a);
}
int p(int num)
{
	int counter=2;
	int rem=0;
	while(counter<num)
	{
		 
		 rem=num%counter;
		if(rem==0)
		{
			printf("\nnumber is not prime");
			break;
		}
		counter=counter+1;
	}
	if(num==counter)
	{
		printf("\nnumber is prime");
	}
}
