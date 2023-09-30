#include<stdio.h>
int main()
{
	int row,col;
	for(row=0;row<=3;row++)
	{
		for(col=0;col<3+row;col++)
		{
			if(col<3-row-1)
			{
				printf(" ");
			}
			else
			{
			 printf("*");
		    }
		}
		printf("\n");
		
	}
}