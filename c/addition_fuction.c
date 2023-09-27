#include<stdio.h>
void addition(int a,int b)
{
 int result=a+b;
 printf("\n%d + %d=%d",a,b,result);	
}
void main(){
	int c,d;
	printf("\nenter two numbers");
	scanf("%d%d",&c,&d);
	addition(c,d);
	printf("\nbye");
}
