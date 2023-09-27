#include<stdio.h>
int main()
{
	int arr[5],i,j,cnt=0;
    for(i=0;i<5;i++)
    {
    	printf("\nenter 5 numbers=");
    	scanf("%d",&arr[i]);
    }
	for(i=0;i<5;i++)
	{
		for(j=i+1;j<5;j++)
		{
			if(arr[i]==arr[j])
			{
				cnt++;
				break;
			}
		}
	}
	printf("\nno of duplicates=%d",cnt);
}