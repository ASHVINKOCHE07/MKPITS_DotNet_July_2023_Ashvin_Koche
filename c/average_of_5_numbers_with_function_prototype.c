#include<stdio.h>
int average();
int main()
{
	int a,b,c,d,e;
	printf("\nenter 5 numbers");
    scanf("%d%d%d%d%d",&a,&b,&c,&d,&e);
    average(a,b,c,d,e);
}
int average(int a,int b,int c,int d,int e)
{
	int average;
	average=(a+b+c+d+e)/5;
	printf("\nAverage of 5 numbers=%d",average);
}
