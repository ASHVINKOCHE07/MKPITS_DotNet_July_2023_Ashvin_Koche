#include<stdio.h>
int main()
{
	int i=1,num;
	printf("\nenter a no.=");
	scanf("%d",&num);
	table:
		 printf("\n%d * %d=%d",num,i,num*i);
    i++;
    if(i<=10)
    {
	  goto table; 
	}
			printf("\nbye");

}