#include<stdio.h>
void main() {
	int num1,num2;
	printf("\nEnter two numbers =");
	scanf("%d%d",&num1,&num2);
	if(num1>num2) {
		printf("%d is greater",num1);
	} else {
		printf("%d is greater",num2);
	}
	return 0;
}
