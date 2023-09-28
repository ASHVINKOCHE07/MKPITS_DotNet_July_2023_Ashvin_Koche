#include<stdio.h>
int main() {
	int num;
	printf("\nEnter number");
	scanf("%d",&num);
	if(num<0) {
		printf("\nNumber is negative");
	} else if(num == 0) {
		printf("\nNumber is Zero");
	} else {
		printf("\nNumber is Positive");
	}
}
