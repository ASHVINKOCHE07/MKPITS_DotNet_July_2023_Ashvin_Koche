#include<stdio.h>
#include<string.h>
struct student
{
	int rno;
	char name[20];
};
void main()
{
	struct student stud[5];
	int counter;
	for(counter=0;counter<5;counter++)
	{
		printf("\nenter 5 student rno and names");
	    printf("\n*****************************\n");
		scanf("%d",&stud[counter].rno);
		scanf("%s",&stud[counter].name);
	}
	printf("\nStudents Details=");
	printf("\n*****************************\n");
	for(counter=0;counter<5;counter++)
	{
		printf("\nrno.=%d",stud[counter].rno);
		printf("\n*****************************\n");
		printf("\nname=%s",stud[counter].name);
		printf("\n*****************************\n");
	}
}