#include<stdio.h>
int main()
{
	int num,*ptr;
	int fact=1;
	printf("\nEnter Number=");
	scanf("%d",&num);
	ptr=&num;
	while(*ptr>0)
	{
	   fact=*ptr * fact;
	   *ptr=*ptr -1;
	}
	  printf("\nFactorial=%d",fact);	
}