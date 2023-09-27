#include<stdio.h>
int main()
{
	int i,marks[3]={80,90,100},sum=0;
	for(i=0;i<3;i++)
	{
		printf("\nmarks are as follows");
		printf("%d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\nsum=%d",sum);
}