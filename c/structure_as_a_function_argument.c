#include<stdio.h>
#include<string.h>
struct book
{
	char title[50],author[50];
	int bookid;
};
void print(struct book b1);
void main()
{
	struct book b1;
	printf("\nEnter title and author and book id");
	scanf("%s",b1.title);
	scanf("%s",b1.author);
	scanf("%d",&b1.bookid);
	print(b1);
}
void print(struct book b1)
{
	printf("\nTitle=%s",b1.title);
	printf("\nAuthor=%s",b1.author);
	printf("\nbook id=%d",b1.bookid);
}