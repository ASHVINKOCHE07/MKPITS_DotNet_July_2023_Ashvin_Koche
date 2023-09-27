#include<stdio.h>
int main()
{
	int i,arr1[5],arr2[5];
	for(i=0;i<5;i++)
	{
		printf("\nenter numbers of first array");
		scanf("%d",&arr1[i]);
	}
	for(i=0;i<5;i++)
	{
		arr2[i]=arr1[i];
	}
	printf("\nelemnets of array 1");
	for(i=0;i<5;i++)
	{
		printf("\n%d",arr1[i]);
	}
	printf("\nelement of array 2");
	for(i=0;i<5;i++)
	{
		printf("\n%d",arr2[i]);
	}
}