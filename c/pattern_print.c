#include<stdio.h>
int main()
{
	int row;
	int col;
	for(row=1;row<=3;row++)
	{
		for(col=1;col<=row;col++)
		{
			printf("\t*");
		}
		printf("\n");
	}
}
