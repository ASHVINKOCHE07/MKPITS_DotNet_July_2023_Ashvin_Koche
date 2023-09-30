#include<stdio.h>
struct workers
{
	int wages,workingdays;
	char name[20];
};
void main()
{
	struct workers std[2];
	int counter;
	for(counter=0;counter<2;counter++)
	{
		printf("\nenter name ,wages and working days");
		scanf("%s",&std[counter].name);
		scanf("%d",&std[counter].wages);
		scanf("%d",&std[counter].workingdays);
	}
	printf("\ndetails of workers");
	for(counter=0;counter<2;counter++)
	{
		printf("\n%s",std[counter].name);
		printf("\n%d",std[counter].wages);
		printf("\n%d",std[counter].workingdays);
	}
}


