#include<stdio.h>
int evenodd()
{
	int a;
	int flag=0;	
	printf("\nenter a numbers");
    scanf("%d",&a);
        if(a%2==0)
		{
			flag=2;
		}
		else
		{
			flag=3;
		}
	return flag;
	return a;
}

int main()
{
	int check;
	check=evenodd();
	if(check==2)
		{
			printf("\nIt is a even number");
		}
		else
		{
			printf("\nIt is a odd number");
		}
}
