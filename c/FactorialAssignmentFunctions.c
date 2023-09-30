#include<stdio.h>
void fact(int a)
{
 int result=1;
 while(a>0)
 {
  result=a*(a-1);
  printf("\nfactorial=%d",result);
  a--;	
}
int main()
{
    int a;
	printf("\nenter a number");
	scanf("%d",&a);
	fact (a);
}

