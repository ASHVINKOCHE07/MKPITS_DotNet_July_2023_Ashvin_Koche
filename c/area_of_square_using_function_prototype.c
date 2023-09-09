#include<stdio.h>
int area();
int main()
{
	int l;
	printf("\nenter side of square");
    scanf("%d",&l);
    area(l);
}
int area(int a)
{
	int area;
	area=a*a;
	printf("\narea of square=%d squnit",area);
}
