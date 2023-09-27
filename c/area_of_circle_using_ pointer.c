#include<stdio.h>
int calculate(int r,float *a,float *c)
{
	*a=3.14*r*r;
	*c=2*3.14*r;
}
int main()
{
	int r;
	float area,circm;
	printf("\nenter Radius=");
	scanf("%d",&r);
	calculate(r,&area,&circm);
	printf("\narea=%.2f sq unit",area);
	printf("\ncircumference=%.2f unit",circm);
}