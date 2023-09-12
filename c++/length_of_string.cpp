#include<stdio.h>
int main()
{
	char name[20],*ptr;
	int count=0;
	printf("\nEnter name=");
	scanf("%c",&name);
	ptr=&name;
	while (*ptr !='\0')
	{
		count=count+1;
	}
	printf("\nlength of string=%d",count);
}