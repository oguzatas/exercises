#include <stdio.h>

void fibonacci(int n);

void main()
{
    int n;
    printf("Enter the number of the elements:");
    scanf("%d",n);
    printf("0 1");
    fibonacci(n-2);
}

void fibonacci(int n)
{
    int n1 = 0, n2 = 1, n3;

    
    if(n>0) {
        n3 = n1 + n2;
        printf(" %d", n3);
        n1 = n2;
        n2 = n3;
        fibonacci(n-1);
    }
}
