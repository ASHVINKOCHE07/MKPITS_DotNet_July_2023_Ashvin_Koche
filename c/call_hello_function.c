#include<stdio.h>
void sayhello()
{
	printf("\nhello");
}
void main()
{
	printf("\n callingfunction");
	sayhello();
	printf("\nback in main");
	sayhello();
	printf("\nbye");
}