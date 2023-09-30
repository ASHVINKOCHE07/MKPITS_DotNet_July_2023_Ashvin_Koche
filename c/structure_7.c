#include<stdio.h>
#include<string.h>
struct student
{
 int fees;
 char sn[30];
};
void main()
{
	struct student stud[5];
	int c;
	float pd,ph;
	printf("\nenter Details(names and fees)>>>>");
	for(c=0;c<5;c++)
	{
		scanf("%s",&stud[c].sn);
		scanf("%d",&stud[c].fees);
	}
	for(c=0;c<5;c++)
	{
		pd=stud[c].fees/(5*30);
		ph=pd/24;
		printf("\nfees of student=%s",stud[c].sn);
		printf("\nfees per day=%.2f",pd);
		printf("\nfees per hour=%.2f",ph);
	}
}