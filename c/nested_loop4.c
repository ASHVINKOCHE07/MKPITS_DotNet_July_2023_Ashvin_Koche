#include<stdio.h>
int main()
{
	int row;
	int col;
	int k=1;
	for(row=1;row<=3;row++)
	{
		for(col=1;col<=row;col++)
		{
			printf("%d",k++);
		}
		printf("\n");
	}
}
