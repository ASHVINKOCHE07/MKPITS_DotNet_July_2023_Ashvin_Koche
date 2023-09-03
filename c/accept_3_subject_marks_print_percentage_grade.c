#include<stdio.h>
int main()
{
	int m1,m2,m3,total;
	float per;
	printf("\nEnter 3 subject marks =");
	scanf("%d%d%d",&m1,&m2,&m3);
	total=m1 + m2 + m3;
	per=(total/300.00f) * 100.0f;
	printf("\nTotal marks = %d",total);
	printf("\nPercentage= %f",per);
	if(per>=75)
	{
		printf("\nGrade=Distinction");
	}
	else if(per>=60 && per<75)
	{
		printf("\nGrade=A");
	}
	else if(per>=50 && per<60)
	{
		printf("\nGrade=B");
	}
	else if(per>=35 && per<35)
	{
		printf("\nGrade=C");
	}
	else
	{
		printf("\nFail");
	}
}
	
	

		
		