#include <stdio.h>

long factorial(int n)

{
    if(n==0) {
        return 1;
        
    }
    else {
        return(n*factorial(n-1));
    }
}

void main() {
    int a;
    long f;
    printf("Enter a number");
    scanf("%d",&a);
    f=factorial(a);
    printf("Here you go=>%ld",f);
}