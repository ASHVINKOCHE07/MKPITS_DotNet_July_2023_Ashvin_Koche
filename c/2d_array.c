#include<stdio.h>
int main()
{
	int arr[2][2]={{1,2},{3,4}};
	int i,j;
	for(i=0;i<2;i++)
	{
		for(j=0;j<2;j++)
		{
			printf("\narr[%d][%d]=%d",i,j,arr[i][j]);
		}
	 } 
}