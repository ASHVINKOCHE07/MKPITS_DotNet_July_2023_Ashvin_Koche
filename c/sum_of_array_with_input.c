#include<stdio.h>
int main()
{
	int i,marks[5],sum=0;
	printf("\nenter marks of 5 subjects");
	for(i=0;i<5;i++)
	{
		scanf("%d",&marks[i]);
	}
	for(i=0;i<5;i++)
	{
		printf("\nmarks=%d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\nsum=%d",sum);
}