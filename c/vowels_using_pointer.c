#include<stdio.h>
#include<string.h>
void main()
{
	int c=0;
	char name[10],*ptr;
	printf("\nenter name");
	gets(name);
	ptr=name;
	while(*ptr!='\0')
	{
		if(*ptr=='a'||*ptr=='e'||*ptr=='i'||*ptr=='o'||*ptr=='u')
		{
			c=c+1;
		}
		ptr++;
	}
	printf("no of vowels in a string=%d",c);
}