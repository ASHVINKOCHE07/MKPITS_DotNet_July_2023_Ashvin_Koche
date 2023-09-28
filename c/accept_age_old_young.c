#include<stdio.h>
void main() {
	int age;
	printf("\nEnter age =");
	scanf("%d",&age);
	if(age>60) {
		printf("%d is old",age);
	} else {
		printf("%d is adult",age);
	}
	return 0;
}
