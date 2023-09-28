#include<stdio.h>
int main() {
	float radius,area,circumference;
	printf("\nEnter Radius of a circle = ");
	scanf("%f",&radius);
	area=3.14f * radius * radius;
	circumference=2 * 3.14f * radius;
	printf("\nArea of a circle = %f sq.units",area);
	printf("\ncircumference of a circle = %f units",circumference);
}
