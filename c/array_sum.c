#include<stdio.h>
int main()
{
	int i,marks[3],sum=0;
	marks[0]=99;
	marks[1]=88;
	marks[2]=77;
	for(i=0;i<3;i++)
	{
		printf("\nmarks are as follows");
		printf("%d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\nsum=%d",sum);
}