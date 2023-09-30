#include<stdio.h>
void main() {
	int num;
	printf("\nEnter number = ");
	scanf("%d",&num);
	if(num%2 == 0) {
		printf("\n %d is even",num);
	} else {
		printf("\n %d is odd",num);
	}
}
