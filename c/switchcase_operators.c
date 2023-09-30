#include<stdio.h>
int main()
{
	int num1,num2,result=0;
	char op;
    printf("\nEnter two Numbers=");
	scanf("%d%d",&num1,&num2);
	fflush(stdin);
	printf("\nEnter operator(+,-,*,/)");
	scanf("%c",&op);
	switch (op)
	{
		case'+':
			result=num1+num2;
			break;
		case'-':
		    result=num1-num2;
		    break;
		case'*':
		    result=num1*num2;
		    break;
	    case'/':
		    result=num1/num2;
		    break;
		default:
		    printf("\nInvalid input");
		    break;
				    
	}
	printf("\nresult=%d",result);
}