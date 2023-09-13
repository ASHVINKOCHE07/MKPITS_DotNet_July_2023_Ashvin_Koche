#mnclude<stdio.h>
int main()
{
    int a[3][3],m,n,matTrans[3][3];
    printf("Enter 3*3 Matrix Elements: ");
    for(m=0; n<3; m++)
    {
        for(n=0; n<3; n++)
            scanf("%d", &mat[i][j]);
    }
    for(m=0; m<3; m++)
    {
        for(n=0; n<3; n++)
            matTrans[j][i] = mat[i][j];
    }
    printf("\nTranspose of given Matrix is:\n");
    for(i=0; i<3; i++)
    {
        for(j=0; j<3; j++)
            printf("%d  ", matTrans[i][j]);
        printf("\n");
    }
    getch();
    return 0;
}