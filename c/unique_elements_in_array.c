#include<stdio.h>
int main()
{
	int a[5],i,cnt=0,j,n;
	printf("\nEnter 5 numbers");
	for(i=0;i<5;i++)
	{
		scanf("%d",&a[i]);
	}
	printf("\nno of unique elements in array");
	for(i=0;i<5;i++)
	{
		for(j=0,n=5;j<n+1;j++)
		{
		if(i!=j)
		{
			if(a[i]==a[j])
			{
				cnt++;
			}
	}
		}
		if(cnt==0)
		{
			printf("%d",a[i]);
		}
	}
}