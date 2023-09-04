#include<stdio.h>
void tabnum (int x);
int main () {
	int num;
	printf (" Enter a number to print the table: ");
	scanf("%d",&num);
    printf("\nTable of %d\n",num);
	tabnum(num);
	return 0;
}
void tabnum (int num) {
	int i;
	for (i=1;i<= 10;i++) {
		printf (" %d x %d = %d \n",num,i,num * i);
	}
}
