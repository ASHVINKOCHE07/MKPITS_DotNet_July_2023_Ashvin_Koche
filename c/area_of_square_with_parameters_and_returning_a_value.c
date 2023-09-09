#include<stdio.h>
int area(int l)
{
	int area;
	area=l*l;
	return area;

}
int main()
{
	int l,m;
	printf("\nenter side of square");
    scanf("%d",&l);
	area(l);
	m=area;
	printf("\narea=%d",m);
}
