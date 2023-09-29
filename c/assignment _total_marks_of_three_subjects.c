#include<stdio.h>
int main() {
	int sub1,sub2,sub3,totalmarks;
	printf("\nenter marks of subject 1 =");
	scanf("%d",&sub1);
	printf("\nenter marks of subject 2 =");
	scanf("%d",&sub2);
	printf("\nenter marks of subject 3 =");
	scanf("%d",&sub3);
	totalmarks=sub1 +  sub2 + sub3;
	printf("\nTotal marks= %d",totalmarks);
}