#include<stdio.h>
int main() {
	int num;
	int result=0;
	int counter;
	printf("\nenter no to print table=");
	scanf("%d",&num);
	for(counter=1; counter<=10; counter++) {
		result=num*counter;
		printf("\n%d * %d = %d",num,counter,result);
	}
}
