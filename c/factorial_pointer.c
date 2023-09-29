#include<stdio.h>
int main()
{
	int a,*ptr,fact,i=1;
	printf("\nenter number= ");
	scanf("%d",&a);
	*ptr=&fact;
	*ptr=1;
	while(i<=a)
	{
		*ptr=*ptr*a;
			printf("\nfactorial of number = %d",*ptr);
		i=i+1;
	}
	printf("\nfactorial of number = %d",fact);
}