#include<stdio.h>
void main() {
	float basic,hra,da,total_salary;
	printf("\nEnter basic=");
	scanf("%f",&basic);
	hra=basic * 0.35;
	da=basic * 0.45;
	total_salary=basic + hra + da;
	printf("HRA = %f \n",hra);
	printf("DA = %f \n",da);
	printf("Total salary = %f \n",total_salary);
	return 0;
}
