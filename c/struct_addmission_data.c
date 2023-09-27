#include<stdio.h>
#include<string.h>
struct student
{
	int addmissionday,addmissionmonth,addmissionyr,birthday,birthmonth,birthyr,rollno;
	char name[20];
	
};
void main()
{
	struct student stud;
	int aged,agem,ageyr;
	    printf("\nenter name;Rollno.;birthday(dd/mm/yy);addmission(dd/mm/yy)");
	    scanf("%s",&stud.name);
		scanf("%d",&stud.rollno);
		scanf("%d",&stud.birthday);
		scanf("%d",&stud.birthmonth);
		scanf("%d",&stud.birthyr);
		scanf("%d",&stud.addmissionday);
		scanf("%d",&stud.addmissionmonth);
		scanf("%d",&stud.addmissionyr);
	ageyr=stud.addmissionyr-stud.birthyr;
	agem=-1*(stud.addmissionmonth-stud.birthmonth);
	aged=-1*(stud.addmissionday-stud.birthday);
	    printf("\nstudent deatails");
		printf("\nstudent Name=%s",stud.name);
		printf("\nstudent Roll No.=%d",stud.rollno);
		printf("\nbirthday %d/%d/%d",stud.birthday,stud.birthmonth,stud.birthyr);
		printf("\nadmission date %d/%d/%d",stud.addmissionday,stud.addmissionmonth,stud.addmissionyr);
	    printf("\nstudent age at time of admission = %d yrs %d months %d days",	ageyr,agem,aged);
}

	
		
		
	

