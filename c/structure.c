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
	strcpy(b1.title,"dotnet");
	strcpy(b1.author,"Ashvin");
	b1.bookid=123;
	printf("\nTitle=%s",b1.title);
	printf("\nAuthor=%s",b1.author);
	printf("\nBookid=%d",b1.bookid);
}