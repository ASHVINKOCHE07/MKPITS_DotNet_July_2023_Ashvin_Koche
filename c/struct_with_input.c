#include<stdio.h>
#include<string.h>
struct Book
{
	char title[50],author[50];
	int bookid;
};
void main()
{
	struct Book b1;
	printf("\nenter Title=");
	scanf("%s",b1.title);
	printf("\nenter author=");
	scanf("%s",b1.author);
	printf("\nenter author=");
	scanf("%d",&b1.bookid);
	printf("\nTitle=%s",b1.title);
	printf("\nAuthor=%s",b1.author);
	printf("\nBookid=%d",b1.bookid);
}