#include<stdio.h>
int area()
{
	int area;
	int a;
	printf("\nenter side of square");
    scanf("%d",&a);
	area=a*a;
	return area;

}
int main()
{
	int l;
	l=area();
    printf("\narea of square=%d squnit",l);
}
