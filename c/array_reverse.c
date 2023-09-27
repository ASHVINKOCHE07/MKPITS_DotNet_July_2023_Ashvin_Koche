#include<stdio.h>
int main()
{
	int n,i,num[100];
	printf("\nenter n");
	scanf("%d",&n);
	for(i=0;i<n;i++)
	{
		printf("\nenter marks");
		scanf("%d",&num[i]);
	}
	for(i=n-1;i>=0;i--)
	{
		printf("\nmarks=%d",num[i]);
	}
}