#include<stdio.h>
void main()
{
	int n1=10,n2=20,*p1=&n1,*p2=&n2,y;
	printf("\nBefore swapping numbers *p1=%d,*p2=%d",*p1,*p2);
    y=*p1;
    *p1=*p2;
    *p2=y;
    printf("\nAfter swapping numbers *p1=%d,*p2=%d",*p1,*p2);
    
}