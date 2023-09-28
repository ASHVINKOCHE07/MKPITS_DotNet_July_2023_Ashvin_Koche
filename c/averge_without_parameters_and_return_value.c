#include<stdio.h>
int main()
{
	int c;
	c=average();
	printf("\nAverage of 5 numbers=%d",c);
}
int average()
{
	int average;
	int a,b,c,d,e;
	printf("\nenter 5 numbers");
    scanf("%d%d%d%d%d",&a,&b,&c,&d,&e);
    average=(a+b+c+d+e)/5;
    return average;
}