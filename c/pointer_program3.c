#include<stdio.h>
#include<string.h>
int main()
{
	int i=0;
	char name[10];
	char *ptr;
	printf("\nenter name");
	gets(name);
	ptr=name;
	while(*ptr != '\0')
	{
		i++;
		ptr++;
	}
	printf("\n length of string=%d",i);
}