#include<stdio.h>
int main() {
	float sub1,sub2,sub3,total,per;
	printf("\nEnter three subject marks =");
	scanf("%f%f%f",&sub1,&sub2,&sub3);
	total=sub1 + sub2 + sub3;
	per=(total/300.0f) * 100;
	printf("\nTotal marks = %f",total);
	printf("\nPercentage = %f",per);

}
