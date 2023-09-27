#include<stdio.h>
struct cricket
{
	int runscored;
	char nameplayer[25];
};
void main()
{
	struct cricket players[11];
	int counter;
	for(counter=0;counter<11;counter++)
	{
		printf("\nenter name;runs;scored");
		scanf("%s",&players[counter].nameplayer);
		scanf("%d",&players[counter].runscored);
	}
	printf("\ncricked players total scored runs");
	for(counter=0;counter<11;counter++)
	{
     	printf("\n%s",players[counter].nameplayer);
		printf("\n%d",players[counter].runscored);
	}
}

	
	


